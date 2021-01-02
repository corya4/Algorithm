package study;

import java.awt.Graphics;
import java.awt.Image;
import java.awt.Toolkit;

import javax.swing.JFrame;


public class SubSqual extends JFrame implements Runnable{
	VoidGame_test1 table;
	Image img;
	Image s_img;
	Graphics s_graphic;
	Toolkit kit = Toolkit.getDefaultToolkit();
	int move_x = 0, move_y = 1;
	double d_x = 0, d_y = 0;
	
	int slop_x = 0;
	int slop_y = 0;
	int add_x;
	SubSqual(VoidGame_test1 vt){
		table = vt;
		img = kit.getImage(System.getProperty("user.dir") + "/src/img/" + "b_block.png");
		img = img.getScaledInstance(50, 50, Image.SCALE_SMOOTH);
		move_x = (int)(Math.random()*table.getWidth()+1);
		
		slop_x = table.x/2 - table.ix/2 - table.mx;
		slop_y = table.y/2 - table.iy/2 - table.my;
	}
	
	@Override
	public void run() {
		//s_img = kit.getImage(System.getProperty("user.dir") + "/src/img/" + "b_block.png");
		
		double slop = ((double)(slop_x - move_x))/((double)(slop_y - move_y));
		System.out.println("플레이어상자 == " + slop_y +", " + slop_x );
		System.out.println("드랍상자 == " + move_y +", " + move_x);
		System.out.println("기울기 == " + slop);
		double checklop = 0;
		add_x = (slop >= 0)?1 : -1;
		
		while(true) {
			
		if(((int)(Math.random()*10001))/10000 == 1 ){
			move_y += 1;
			double tmp_s = checklop;
			checklop += slop;
			if((int)checklop != (int)tmp_s) move_x += add_x;
		}
		
		if(move_y > table.getHeight()) {
			break;
		}
		
		if(table.y/2 - table.iy/2 - table.my < move_y + 50 && table.y/2 - table.iy/2 - table.my + 50 > move_y) {
			if(table.x/2 - table.ix/2 - table.mx < move_x+50 && table.x/2 - table.ix/2 - table.mx + 50 > move_x) {
				System.out.println("앙 죽음");
				throw new NullPointerException();
			}
		}
		update(table.buf_g);
		
		}	
	}

	@Override
	public void paint(Graphics g) {
		//s_graphic = table.getGraphics();
		//System.out.println(move_x);
		g.drawImage(img, move_x, move_y, table);
		table.repaint();
	}

	@Override
	public void update(Graphics g) {
		super.update(g);
		
	}

	
}
