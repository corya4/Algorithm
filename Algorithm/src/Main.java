import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Main {
		static int[] stails;
		static int[][] dp;
		public static void main(String[] args) throws NumberFormatException, IOException {
			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
			int length = Integer.parseInt(br.readLine());
			stails = new int[length+1];
			dp = new int[3][length];
			for(int i = 0; i < dp.length; i++) {
				Arrays.fill(dp[i], -1);
			}
			for(int i = 1; i < stails.length; i++) {
				stails[i] = Integer.parseInt(br.readLine());
			}
			System.out.println(toUpper(0, 1, 0));
		}
		static int toUpper(int p, int s, int t) {
			if(p >= stails.length-1) {
				int turn = -100000;
				if((p == stails.length-1)) {
					turn = stails[p];
				}
				return turn;
			}
			if(dp[t][p] != -1) {
				return dp[t][p];
			}
			int max = 0;
			for(int i  = 1; i <= 2; i++) {
				if(i == 2) {
					s = 1;
				}else if(s%3 == 0 && i == 1) {
					continue;
				}
				max = Math.max(max, toUpper(p+i, s+1, i) + stails[p]);
			}
			return dp[t][p] = max;
		}
	}





