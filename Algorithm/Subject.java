package study;

public class Subject implements Runnable{
	private int x;
	private int y;
	VoidGame_test1 table;
	
	Subject(VoidGame_test1 table){
		this.table = table;
	}
	
	@Override
	public synchronized void run() {
		long start = System.currentTimeMillis();
		long end;
		long time_up;
		int time_set = 5;
		int count = 1;
		
		try {
			this.wait(1000);
		} catch (InterruptedException e1) {
			e1.printStackTrace();
		}
		//table 생성 waiting
		
		while(true) {
			end = System.currentTimeMillis();
			time_up = (end-start)/1000;
			if(time_up%time_set == 0) {
				SubSqual ss = new SubSqual(table);
				Thread thread = new Thread(ss);
				thread.setDaemon(true);
				thread.start();
				System.out.println(count + "개 생성");
				count++;
				if(count%5 == 0) time_set -= 1;
				try {
					this.wait(1000);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}catch(NullPointerException ne) {
					break;
				}
			}
			
		}
		
		
	}
	
	
}
