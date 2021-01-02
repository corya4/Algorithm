package study;

import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Calendar;

public class AutoProcessing implements Runnable{
	
	String ap;
	String hour;
	String minute;
	String fileName;
	
	
	@Override
	public void run() {
		SimpleDateFormat currentTime = new SimpleDateFormat("HH:mm");
		Calendar date = Calendar.getInstance();
		String alr = currentTime.format(date.getTime());
		
		String tHour =  String.valueOf(((ap.equals("PM")) ? 12:0) + Integer.parseInt(getHour()));
		String tMinute = getMinute();
		
		String setAlr = tHour + ":" + tMinute;
		
		System.out.println(setAlr);
		while(true) {
			
			if(setAlr.equals(alr)) {
				Runtime runtime = Runtime.getRuntime();
				try {
					
					Process p = runtime.exec(getFileName());
					p.getErrorStream().close();
					p.getInputStream().close();
					p.getOutputStream().close();
					p.waitFor();
					
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (InterruptedException e) {
					
				}
				
				break;
			}
			alr = currentTime.format(Calendar.getInstance().getTime());
		}
		
		System.out.println(alr);
	}
	

	
	
	/*
	 * get set
	 */
	public String getAp() {
		return ap;
	}
	
	public void setAp(String mp) {
		this.ap = mp;
	}

	public String getHour() {
		return hour;
	}

	public void setHour(String hour) {
		this.hour = hour;
	}

	public String getMinute() {
		return minute;
	}

	public void setMinute(String minute) {
		this.minute = minute;
	}

	public String getFileName() {
		return fileName;
	}

	public void setFileName(String fileName) {
		this.fileName = fileName;
	}

	
}
