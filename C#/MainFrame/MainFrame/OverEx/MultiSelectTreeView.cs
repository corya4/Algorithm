using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MainFrame
{
	/// <summary>
	/// TreeViewを相続
	/// </summary>
	public class TreeViewMS : System.Windows.Forms.TreeView
	{
		public ArrayList		m_coll;
		protected TreeNode		m_lastNode, m_firstNode;
		
		public TreeViewMS()
		{
			m_coll = new ArrayList();
		}


		/// <summary>
		/// Overrideする時メソッド
		/// </summary>
		/// <param name="pe"></param>
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		
		/// <summary>
		/// 選択したNodeを集まるリスト
		/// </summary>
		public ArrayList SelectedNodes
		{
			get
			{
				return m_coll;
			}
			set
			{
				removePaintFromNodes();
				m_coll.Clear();
				m_coll = value;
				paintSelectedNodes();
			}
		}


		protected override void OnBeforeSelect(TreeViewCancelEventArgs e)
		{
			base.OnBeforeSelect(e);
				
			bool bControl = (ModifierKeys==Keys.Control);
			bool bShift = (ModifierKeys==Keys.Shift);

			//選択した時、ShiftキーかCtnlキーを押したか
			if (bControl && m_coll.Contains( e.Node ) )
			{
				//Ctnlを押した時、同じNodeを選択したらイベント無効
				e.Cancel = true;
	
				// 選択したNodeをリストでRemove
				removePaintFromNodes();
				m_coll.Remove( e.Node );
				paintSelectedNodes();
				return;
			}

			m_lastNode = e.Node;
			if (!bShift) m_firstNode = e.Node; //ShiftキーのスタートNode
		}



		protected override void OnAfterSelect(TreeViewEventArgs e)
		{
			base.OnAfterSelect(e);

			bool bControl = (ModifierKeys==Keys.Control);
			bool bShift = (ModifierKeys==Keys.Shift);

			if (bControl)
			{
				if ( !m_coll.Contains( e.Node ) ) // SelectリストにあるNodeか？
				{
					m_coll.Add( e.Node );
				}
				else  // もうあるNodeなら
				{
					removePaintFromNodes();
					m_coll.Remove( e.Node );
				}

				//SelectできたNodeにColorを入れる
				paintSelectedNodes();
			}
			else 
			{
				if (bShift)
				{
					Queue myQueue = new Queue();
					
					TreeNode uppernode = m_firstNode;
					TreeNode bottomnode = e.Node;
					
					bool bParent = isParent(m_firstNode, e.Node); // m_firstNodeがディレクトリで、e.Nodeがm_firstNodeのChildかを確認
					if (!bParent)
					{
						bParent = isParent(bottomnode, uppernode);
						if (bParent) // 反対で確認
						{
							TreeNode t = uppernode;
							uppernode = bottomnode;
							bottomnode = t;
						}
					}

					if (bParent)
					{
						TreeNode n = bottomnode;

						//if <- add
						// 2020.07.13
						// Hong ki jung
						while (n != uppernode.Parent)
						{
							if ( !m_coll.Contains( n ) )
								myQueue.Enqueue( n );

							n = n.Parent;
						}
					}
						
					else
					{
						if ( (uppernode.Parent==null && bottomnode.Parent==null) || (uppernode.Parent!=null && uppernode.Parent.Nodes.Contains( bottomnode )) ) // bottomnodeがuppernodeのChildの場合
						{
							int nIndexUpper = uppernode.Index;
							int nIndexBottom = bottomnode.Index;
							if (nIndexBottom < nIndexUpper) // 選択順が反対の時
							{
								TreeNode t = uppernode;
								uppernode = bottomnode;
								bottomnode = t;
								nIndexUpper = uppernode.Index;
								nIndexBottom = bottomnode.Index;
							}

							TreeNode n = uppernode;

							
							while (nIndexUpper <= nIndexBottom)
							{

								
								if (!m_coll.Contains( n ) )
									myQueue.Enqueue( n );
								
								n = n.NextNode;

								nIndexUpper++;
							}
							
						}
						else
						{
							if ( !m_coll.Contains( uppernode ) ) myQueue.Enqueue( uppernode );
							if ( !m_coll.Contains( bottomnode ) ) myQueue.Enqueue( bottomnode );
						}
					}

					m_coll.AddRange( myQueue ); // selectリストに入れる

					paintSelectedNodes();
					m_firstNode = e.Node; // また、Shiftキーを押す場合をため、m_firstNodeを初e.Nodeで初期化
				} // end if m_bShift
				else
				{
					// ただ、Clickした時
					if (m_coll!=null && m_coll.Count>0)
					{
						removePaintFromNodes();
						m_coll.Clear();
					}

					
					 m_coll.Add(e.Node);
				}
			}
		}



// Helpers
//
//


		protected bool isParent(TreeNode parentNode, TreeNode childNode)
		{
			if (parentNode==childNode)
				return true;

			TreeNode n = childNode;
			bool bFound = false;
			while (!bFound && n!=null)
			{
				n = n.Parent;
				bFound = (n == parentNode);
			}
			return bFound;
		}


		/// <summary>
		/// 選択したNodeのColorを入れる
		/// </summary>
		protected void paintSelectedNodes()
		{
			
			foreach ( TreeNode n in m_coll )
			{

				if (n.ForeColor == Color.Gray) continue; // add if

				n.BackColor = SystemColors.Highlight;
				n.ForeColor = SystemColors.HighlightText;
			}
		}



		//protected -> public
		//2020.07.12
		//Hongkijung
		/// <summary>
		/// NodeのColorクリア
		/// </summary>
		public void removePaintFromNodes()
		{

			if (m_coll.Count==0 ) return;

			TreeNode n0 = (TreeNode) m_coll[0];

			if (n0.TreeView == null) return;

			Color back = n0.TreeView.BackColor;
			Color fore = n0.TreeView.ForeColor;

			foreach ( TreeNode n in m_coll )
			{
				n.BackColor = back;
				if (n.ForeColor != Color.Gray)
					n.ForeColor = fore;
			}

		}

	}
}
