
package study;

import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Stack;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;


class EventButton implements ActionListener{
	Calculator_GUI cal;
	String n;
	EventButton(Calculator_GUI s){
		cal = s;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) { 
		JButton eb = (JButton)e.getSource();
		if(eb.getText().equals("C")) { 
			cal.label1.setText(" ");
		}else if(eb.getText().equals("=")) {
			n = cal.label1.getText().trim();
			if(n.length() == 0) {
				cal.label1.setText("0");
				return;
			}
			calculate();
		}else if(eb.getText().equals("r")) { 
			n = cal.label1.getText().trim();
			root();
		}else {
			cal.label1.setText(cal.label1.getText()+eb.getText());
		}
	}
	
	private void calculate() { 
		Stack<Character> calc = new Stack<Character>(); 
		Stack<Integer> stack = new Stack<Integer>(); 
		String temp=""; 
		for(int i = 0; i < n.length(); i++) {
			if(String.valueOf(n.charAt(i)).matches("^[0-9]*$")) { 
				temp += String.valueOf(n.charAt(i));
			}else {
				if(!temp.equals("")) { 
				stack.push(Integer.parseInt(temp)); 
				temp=""; 
				}
				char c = n.charAt(i); 
				if(c == '(') { 
					calc.push(c);
				}else if(c == ')'){ 
					while(calc.peek() != '(') {
						calcul(stack,calc.pop()); 
					}
					calc.pop(); 
				}else {
					if(calc.isEmpty() || calc.peek() == '(' || checkPrio(c) >= checkPrio(calc.peek())) { 
						calc.push(c);
						calcul(stack, calc.pop());
						calc.push(c);
					}
				}
				
			}
		}
		if(!temp.equals("")) stack.push(Integer.parseInt(temp));
		
		while(!calc.isEmpty()) {
			calcul(stack,calc.pop());
		}
		int result = stack.pop();
		cal.label1.setText((result+""));
	}
	private void calcul(Stack<Integer> s, char c) { 
		int a = s.pop();
		int b = s.pop();
		int r = 0;
		
		switch(c) {
		case '+' : r = a+b;
		break;
		case '-' : r = a-b;
		break;
		case '*' : r = a*b;
		break;
		case '/' : r = a/b;
		break;
		case '%' : double f = (b*0.01);
				   r = ((int)(a*f));
		}
		s.push(r);
	}
	private void root() { //루트값 메소드
		int value = Integer.parseInt(n);
		int result = (int) Math.sqrt((int)value);
		cal.label1.setText(result+"");
	}
	private int checkPrio(char c) { //연산 우선순위 체크
		switch(c) {
		case '+' : return 1;
		case '-' : return 1;
		case '*' : return 2;
		case '/' : return 3;
		default : return 1;
		}
	}
}

public class Calculator_GUI extends JFrame {
	EventButton event;
	BorderLayout main;
	JPanel panel;
	JPanel panel2;
	JLabel label1;
	GridLayout grid;
	GridLayout grid2;
	JButton[] btns;
	
	Calculator_GUI(String title){
		super.setTitle(title);
		
		this.setSize(250, 350);
		this.setLocation(100, 50);
		setting();
		
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	
	private void setting() { 
		event = new EventButton(this);
		main = new BorderLayout();
		panel = new JPanel();
		panel2 = new JPanel();
		grid = new GridLayout();
		grid2 = new GridLayout(4,5);
		panel.setLayout(grid);
		panel2.setLayout(grid2);
		label1 = new JLabel(" ");
		label1.setHorizontalAlignment(JLabel.RIGHT);
		btns = new JButton[20];
		
		this.setLayout(main);
		panel.add(label1);
		this.add(panel2, BorderLayout.CENTER);
		this.add(panel, BorderLayout.NORTH);
		for(int i = 0; i < btns.length; i++) {
			btns[i] = new JButton();
			btns[i].addActionListener(event);
			panel2.add(btns[i]);
		}
		btns[0].setText("+"); btns[1].setText("-"); btns[2].setText("*"); btns[3].setText("/"); btns[4].setText("r");
		btns[5].setText("7"); btns[6].setText("8"); btns[7].setText("9"); btns[8].setText("("); btns[9].setText("%");
		btns[10].setText("4"); btns[11].setText("5"); btns[12].setText("6"); btns[13].setText(")"); btns[14].setText("C");
		btns[15].setText("1"); btns[16].setText("2"); btns[17].setText("3"); btns[18].setText("0"); btns[19].setText("=");
		
	}

	public static void main(String[] args) {
		new Calculator_GUI("기본 계산기ver.1");
	}
}
