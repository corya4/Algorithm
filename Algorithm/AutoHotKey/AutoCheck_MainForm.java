package study;

import java.awt.GridLayout;
import java.awt.Label;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.FocusEvent;
import java.awt.event.FocusListener;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.filechooser.FileNameExtensionFilter;

public class AutoCheck_MainForm extends JFrame implements ActionListener, FocusListener{

	JPanel top, mid, bot;
	Label timelbl, statelbl, commalbl;
	JComboBox apcbx;
	JTextField hourText, minuteText, fileText;
	JButton startbtn, endbtn;
	
	String[] half = {"AM", "PM"};
	String[] state = {"Running", "Waiting"};
	
	AutoProcessing process = null;
	/*
	 * Main logic
	 */
	public AutoCheck_MainForm(String title){
		super(title);
		init();
		
		
		
		this.setSize(700, 400);
		this.setVisible(true);
		this.setDefaultCloseOperation(this.EXIT_ON_CLOSE);
	}
	
	
	/*
	 * Component insert Method
	 */
	public void init() {
		this.setLayout(new GridLayout(3, 1));
		
		timelbl = new Label("Set Time");
		statelbl = new Label(state[1]); //dynamic
		commalbl = new Label(" : ");
		
		apcbx = new JComboBox(half);
		
		hourText = new JTextField(3); 
		minuteText = new JTextField(6);
		fileText = new JTextField(30); 
		
		startbtn = new JButton("Start");
		endbtn = new JButton("End");
		
		top = new JPanel();
		top.add(timelbl); top.add(statelbl);
		
		mid = new JPanel();
		mid.add(apcbx); mid.add(hourText); mid.add(commalbl); mid.add(minuteText);
		
		bot = new JPanel();
		bot.add(fileText); bot.add(startbtn); bot.add(endbtn);
		
		this.add(top);
		this.add(mid);
		this.add(bot);
		
		//Event Set
		fileText.addFocusListener((FocusListener)this);
		startbtn.addActionListener((ActionListener)this);
		endbtn.addActionListener((ActionListener)this);
	}
	
	
	
	/*
	 * Algo Start
	 * -main method
	 */
	public static void main(String[] args) {
		new AutoCheck_MainForm("Enitec 자동 출석 ver1.0");
	}


	/*
	 * Button Event
	 */
	@Override
	public void actionPerformed(ActionEvent e) {
		
		JButton event = (JButton)e.getSource();
		Thread alr = null;
		
		if(event.getText().equals("Start")) {
			
			if(process == null) {
				process = new AutoProcessing();
			}else {
				JOptionPane.showMessageDialog(null, "Processing","Error", JOptionPane.WARNING_MESSAGE);
				return;
			}
			
			List<String> errors = new ArrayList<String>();
			
			if(hourText.getText().equals("")) errors.add("Insert Hour");
			if(minuteText.getText().equals("")) errors.add("Inster Minute");
			if(fileText.getText().equals("")) errors.add("Insert FileName");
			
			if(errors.size() != 0) {
				String errorText = "";
				for(String err : errors) errorText += err + '\n';
				JOptionPane.showMessageDialog(null, errorText,"Error", JOptionPane.WARNING_MESSAGE);
				return;
			}
			
			process.setAp(apcbx.getSelectedItem().toString());
			process.setHour(hourText.getText());
			process.setMinute(minuteText.getText());
			process.setFileName(fileText.getText());
			
			alr = new Thread(process);
			alr.setDaemon(true);
			alr.start();
			statelbl.setText(state[0]);
			
		}else if(event.getText().equals("End")) {
			if(process == null) return;
			try {
				alr.interrupt();
			}catch (Exception et) {
				// TODO: handle exception
			}
			
			alr = null;
			process = null;
			statelbl.setText(state[1]);
		}
	}


	
	/*
	 * TextBox Event
	 */
	@Override
	public void focusGained(FocusEvent e) {
		JFileChooser fDlog = new JFileChooser();
		fDlog.addChoosableFileFilter(new FileNameExtensionFilter("EXE (*.exe)", "exe"));
		
		if((fDlog.showOpenDialog(this) == JFileChooser.APPROVE_OPTION)) {
			fileText.setText(fDlog.getSelectedFile().toString());
		}
		
		fileText.setFocusable(false);
		startbtn.setFocusable(true);
	}


	@Override
	public void focusLost(FocusEvent e) {
		
	}

}









