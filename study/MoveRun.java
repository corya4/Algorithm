package study;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class MoveRun implements Runnable, KeyListener{
	VoidGame_test1 table;
	KeyEvent e;
	String type;
	
	boolean up;
	boolean down;
	boolean right;
	boolean left;
	
	MoveRun(VoidGame_test1 table, KeyEvent e, String e_type){
		this.table = table;
		this.e = e;
		this.type = e_type;
	}
	
	@Override
	public void run() {
		if(type.equals("push")) keyPressed(e);
		else keyReleased(e);
	}

	@Override
	public void keyTyped(KeyEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void keyPressed(KeyEvent e) {
		int keycode = e.getKeyCode();
		
		switch(keycode){
		case KeyEvent.VK_UP :
			up = true;
			break;
		case KeyEvent.VK_DOWN :
			down = true;
			break;
		case KeyEvent.VK_RIGHT :
			right = true;
			break;
		case KeyEvent.VK_LEFT :
			left = true;
			break;
		}
		
		if(up) table.my += 10;
		if(down) table.my -= 10;
		if(right) table.mx -= 10;
		if(left) table.mx += 10;
		
		
		table.repaint();
	}

	@Override
	public void keyReleased(KeyEvent e) {
		int keycode = e.getKeyCode();
		
		switch(keycode) {
		case KeyEvent.VK_UP :
			up = false;
			break;
		case KeyEvent.VK_DOWN :
			down = false;
			break;
		case KeyEvent.VK_RIGHT :
			right = false;
			break;
		case KeyEvent.VK_LEFT :
			left = false;
			break;
		}
		
	}

}
