package study;

import java.awt.Graphics;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

import javax.swing.JFrame;

public class VoidGame_test1 extends JFrame implements KeyListener {
	Image buf_i;
	Image img;
	Graphics buf_g;
	Toolkit kit;

	int x, y;
	int ix, iy;
	int mx = 0;
	int my = 0;

	boolean up;
	boolean down;
	boolean right;
	boolean left;

	VoidGame_test1(String title) {
		super(title);
		kit = getToolkit().getDefaultToolkit();
		img = kit.getImage(System.getProperty("user.dir") + "/src/img/" + "g_block.png");
		img = img.getScaledInstance(50, 50, Image.SCALE_SMOOTH);
		this.setSize(500, 500);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
		this.setDefaultCloseOperation(this.EXIT_ON_CLOSE);

		addKeyListener(this);

		x = getWidth();
		y = getHeight();

		System.out.println("투사체 생성");
		Subject sub = new Subject(this);
		Thread thread = new Thread(sub);
		thread.setDaemon(true);
		thread.run();
		

	}

	public static void main(String[] args) {
		new VoidGame_test1("피하기 게임1");

	}

	@Override
	public void paint(Graphics g) {
		if (buf_g == null)
			buf_i = createImage(x, y);
		if (buf_i != null)
			buf_g = buf_i.getGraphics();
		paintComponents(buf_g);
		ix = img.getWidth(null);
		iy = img.getHeight(null);
		buf_g.drawImage(img, ((x / 2) - (ix / 2)) - mx, ((y / 2) - (iy / 2)) - my, this);
		g.drawImage(buf_i, 0, 0, this);
	}

	@Override
	public void keyTyped(KeyEvent e) {
		// TODO Auto-generated method stub

	}

	@Override
	public void keyPressed(KeyEvent e) {
		/*
		 * MoveRun move = new MoveRun(this, e, "push"); Thread thread = new
		 * Thread(move); thread.run();
		 */

		int keycode = e.getKeyCode();

		switch (keycode) {
		case KeyEvent.VK_UP:
			up = true;
			break;
		case KeyEvent.VK_DOWN:
			down = true;
			break;
		case KeyEvent.VK_RIGHT:
			right = true;
			break;
		case KeyEvent.VK_LEFT:
			left = true;
			break;
		}

		if (up)
			my += 10;

		if (down)
			my -= 10;

		if (right)
			mx -= 10;

		if (left)
			mx += 10;

		repaint();
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
	case  KeyEvent.VK_RIGHT : 
		right =false; 
		  break; 
	 case KeyEvent.VK_LEFT : 
		 left = false;
		  break;
		}
		 
	}
}
