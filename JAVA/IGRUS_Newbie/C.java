package IGRUS_Newbie;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigInteger;

public class C {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		BigInteger value = new BigInteger(br.readLine());
		BigInteger Two = new BigInteger("2");
		
		for(int i = 64; i >= 0; i--) {
			
			 if(MinSame(value, Two.pow(i), i)) { 
				 System.out.println(i);
				 break;
			 }
			 
		}
	}
	
	 public static boolean MinSame(BigInteger n, BigInteger m, int L) {
	  
	 if(L > 64) return false; 
	 if(n.equals(m) || n.equals(m.subtract(BigInteger.ONE))) return true;
	  
	  if(MinSame(n, m.multiply(BigInteger.valueOf(2)), L + 1) ||
			  MinSame(n,m.multiply(BigInteger.valueOf(2)).subtract(BigInteger.ONE), L + 1)) return true;
	  
	  return false; 
	  }
	 

}












