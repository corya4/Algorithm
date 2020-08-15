package help;

import java.util.ArrayList;

public class Throws_Catch {

	public static void main(String[] args) {
		
		try {
			
			exceptionTest();
			
		}catch(NullPointerException ne) {
			System.out.println("null Error");
		}catch(NumberFormatException fe) {
			System.out.println("format Error");
		} /*
			 * catch(Exception e) { System.out.println("All Error"); }
			 */
		exceptionTest();

	}
	
	static void exceptionTest() throws NullPointerException{
		
		ArrayList list = null;
		
		list.get(0);
	}

}
