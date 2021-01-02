package JAVA;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Comparator;
import java.util.StringTokenizer;

public class BOJ_1922 {
   
   static Integer[][] cost;
   static int[] connect;
   static int connection;
   
   public static void main(String[] args) throws IOException{
      init();
      Arrays.sort(cost, new Comparator<Integer[]>() {
         @Override
         public int compare(Integer[] o1, Integer[] o2) {
            return o1[2] - o2[2];
         }
      });
   
      int min_value = 0;
      int distance = 0;
      
      for(int i = 0; i < cost.length; i++) {
    	  if(distance == connection) break;
    	 int s = Union_find(cost[i][0]);
    	 int e = Union_find(cost[i][1]);
    	 
    	 
    	 if(s < e) {
    		 connect[s] = e;
    	 }else if(s > e){
    		 connect[e] = s;
    	 }
    	
    	 if(s != e) {
    		 min_value += cost[i][2];
    		 distance++;
    	 }
    	 
      }
      System.out.println(min_value);
   }
   
   static void init() throws IOException{
      BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
      int node = Integer.parseInt(br.readLine());
      connection = node;
      connect = new int[node+1];
      int length = Integer.parseInt(br.readLine());
      cost = new Integer[length][3];
      StringTokenizer stn;
      
      for(int i = 0; i < length; i++) {
         stn = new StringTokenizer(br.readLine(), " ");
         cost[i][0] = Integer.parseInt(stn.nextToken());
         cost[i][1] = Integer.parseInt(stn.nextToken());
         cost[i][2] = Integer.parseInt(stn.nextToken());
      }
      
      for(int j = 0; j < connect.length; j++) {
    	  connect[j] = j;
      }
   }
   
   static int Union_find(int v) {
	   if(v == connect[v]) {
		   return v;
	   }else {
		   return Union_find(connect[v]);
	   }
   }
   
   
}