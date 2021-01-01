package ps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.StringTokenizer;

class Tree{
	int age;
	
	Tree(int age){
		this.age = age;
	}
	@Override
	public String toString() {
		return "Tree [age=" + age + "]";
	};

}


public class BOJ_16235 {
	static BufferedReader br; 		// �Է½�Ʈ��
	static ArrayList<ArrayList<ArrayList<Tree>>> Trees
						= new ArrayList<ArrayList<ArrayList<Tree>>>();
									// �����ʵ�
	static int[][] Field;			// �κ���� �ʵ�
	static int[][] Energy;			// ����ʵ�
	public static void main(String[] args) throws IOException {
		int N, M, K; 				// 1. �����ʵ� �迭���� 2. ��зκ� ����, 3. �ݺ�(���� ��)Ƚ��
		
		///////////
		//Binding//
		//////////////////////////////////////////////////////////////////
		br = new BufferedReader(new InputStreamReader(System.in));		//
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");	//
																		//
		N = Integer.parseInt(stn.nextToken());	//�ʵ� ũ��				//
		M = Integer.parseInt(stn.nextToken());	//�ʱ⳪������				//
		K = Integer.parseInt(stn.nextToken());	//�ݺ�Ƚ��					//
																		//
		Field = CreateArr(N); 		// �κ� ��� �߰��� �ʵ�.					//
		CreateTreeField(N);												//
		Energy = InEnergy(N, 5); 	// �ʵ峻 ��� ��.						//
		CreateTree(M); 				// �ʱ� ���� ����.						//
		//////////////////////////////////////////////////////////////////
		
		AnswerTree(Field, Energy, K);
		
	}
	
	// �� ó�� �޼ҵ�.
	private static void AnswerTree(int[][] Field, int[][] Energy, int Year) {
		for(int i = 0; i < Year; i++) {
			SpringSummer(Energy);
			FallWinter(Field, Energy);
		}
	
		CountTrees();
	}
	
	// �κ��߰��� ��ǲ �� ���� �޼ҵ�.
	private static int[][] CreateArr(int x) throws IOException{
		int[][] fArr = new int[x][];
		
		for(int i = 0; i < x; i++) {
			fArr[i] = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		}
		
		return fArr;
	}

	// �ʱ� ���� �߰� �޼ҵ�.
	private static void CreateTree(int x) throws IOException {
		
		for(int i = 0; i < x; i++) {
			int[] tArr = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
			InTree(tArr[0], tArr[1], tArr[2]);
		}
	}
	
	// ���� �ʵ� �ʱ�ȭ �޼ҵ�.
	private static void CreateTreeField(int x) {
		for(int i = 0; i < x; i++) {
			Trees.add(new ArrayList<ArrayList<Tree>>());
			for(int j = 0; j < x; j++) {
				Trees.get(i).add(new ArrayList<Tree>());
			}
		}
	}
	
	// ��а� ��ǲ �� ���� �޼ҵ�.
	private static int[][] InEnergy(int n, int e){
		int[][] eArr = new int[n][n];
		
		for(int i = 0; i < n; i++) Arrays.fill(eArr[i], e);
		
		return eArr;
	}
	
	// ��ǥ�� ���� ��ǲ �޼ҵ�.
	private static void InTree(int x, int y, int age) {
		Trees.get(x- 1).get(y- 1).add(new Tree(age));
	}
	
	// ��ǥ ����s ����� ���� �� ���� ����.
	private static void Intake(int x, int y){
		
		boolean tFlag = true;
		ArrayList<Tree> tmpArr = Trees.get(x).get(y);
		for(int i = 0; i < tmpArr.size(); i++) {
			
			if(tFlag && Energy[x][y] >= tmpArr.get(i).age) {
				Energy[x][y] -= tmpArr.get(i).age;
				tmpArr.get(i).age++;
			
			//(���̿� ���� ��м��� ���� �� ����(����) �� ����/2 ��� �߰�)
			}else {
				if(tFlag) tFlag = false;
				int t = tmpArr.get(i).age;
				Energy[x][y] += t/2;
				tmpArr.remove(i);
				System.out.println(tmpArr);
				i--;
			}
		}
	}
	
	// ���� ���� �޼ҵ�.
	private static void Planting(int x, int y) {
		ArrayList<Tree> tmpList = Trees.get(x).get(y);
		
		for(int i = 0; i < tmpList.size(); i++) {
			if(tmpList.get(i).age % 5 != 0) continue;
			// �ʵ� ���� üũ
			for(int tx = -1; tx < 2; tx++) {			
				for(int ty = -1; ty < 2; ty++) {
					if(tx == 0 && ty == 0) continue;
					if(!CheckFieldSize(x, y, tx, ty)) continue;
					// ���̰� 1�� ���� ����.
					Trees.get(x + tx).get(y + ty).add(new Tree(1));
				}
			}
			
		}

	}
	
	// �ʵ� ������ üũ �޼ҵ�.
	private static boolean CheckFieldSize(int x, int y, int tx, int ty) {
		if((x + tx) < 0 || Trees.size() < (x + tx)) return false;
		if((y + ty) < 0 || Trees.size() < (y + ty)) return false;
		
		return true;
	}

	// S2D2 ��� �߰� �޼ҵ�.
	private static void AddEnergy() {
		int length = Field.length;
		
		for(int i = 0; i < length; i++) {
			for(int j = 0; j < length; j++) {
				Energy[i][j] += Field[i][j];
			}
		}
	}
		
	private static void SpringSummer(int[][] Energy) {
		int length = Trees.size();
				
		for(int i = 0; i < length; i++) {
			for(int j = 0; j < length; j++) {
				// ���� ������������ ����.
				Collections.sort(Trees.get(i).get(j), new Comparator<Tree>() {
					@Override
					public int compare(Tree o1, Tree o2) {
						return (o1.age > o2.age) ? 1 : (o1.age < o2.age) ? -1 : 0;
					}
					
				});
				Intake(i, j);
			}
		}
	}
	
	private static void FallWinter(int[][] Field, int[][] Energy) {
		int length = Trees.size();
		
		for(int i = 0; i < length; i++) {
			for(int j = 0; j < length; j++) {
				Planting(i, j);
			}
		}
		
		AddEnergy();
	}
	
	// ���� ��ü �� ���.
	private static void CountTrees() {
		int answer = 0;
		int length = Trees.size();
		
		for(int i = 0; i < length; i++) {
			for(int j = 0; j < length; j++) {
				int tmp = Trees.get(i).get(j).size();
				answer += tmp;
			}
		}
		
		System.out.println(answer);
	}
}












