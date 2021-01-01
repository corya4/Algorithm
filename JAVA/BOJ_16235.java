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
	static BufferedReader br; 		// 입력스트림
	static ArrayList<ArrayList<ArrayList<Tree>>> Trees
						= new ArrayList<ArrayList<ArrayList<Tree>>>();
									// 나무필드
	static int[][] Field;			// 로봇양분 필드
	static int[][] Energy;			// 양분필드
	public static void main(String[] args) throws IOException {
		int N, M, K; 				// 1. 나무필드 배열길이 2. 양분로봇 갯수, 3. 반복(지난 해)횟수
		
		///////////
		//Binding//
		//////////////////////////////////////////////////////////////////
		br = new BufferedReader(new InputStreamReader(System.in));		//
		StringTokenizer stn = new StringTokenizer(br.readLine(), " ");	//
																		//
		N = Integer.parseInt(stn.nextToken());	//필드 크기				//
		M = Integer.parseInt(stn.nextToken());	//초기나무갯수				//
		K = Integer.parseInt(stn.nextToken());	//반복횟수					//
																		//
		Field = CreateArr(N); 		// 로봇 양분 추가값 필드.					//
		CreateTreeField(N);												//
		Energy = InEnergy(N, 5); 	// 필드내 양분 값.						//
		CreateTree(M); 				// 초기 나무 생성.						//
		//////////////////////////////////////////////////////////////////
		
		AnswerTree(Field, Energy, K);
		
	}
	
	// 값 처리 메소드.
	private static void AnswerTree(int[][] Field, int[][] Energy, int Year) {
		for(int i = 0; i < Year; i++) {
			SpringSummer(Energy);
			FallWinter(Field, Energy);
		}
	
		CountTrees();
	}
	
	// 로봇추가값 인풋 후 리턴 메소드.
	private static int[][] CreateArr(int x) throws IOException{
		int[][] fArr = new int[x][];
		
		for(int i = 0; i < x; i++) {
			fArr[i] = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
		}
		
		return fArr;
	}

	// 초기 나무 추가 메소드.
	private static void CreateTree(int x) throws IOException {
		
		for(int i = 0; i < x; i++) {
			int[] tArr = Arrays.asList(br.readLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();
			InTree(tArr[0], tArr[1], tArr[2]);
		}
	}
	
	// 나무 필드 초기화 메소드.
	private static void CreateTreeField(int x) {
		for(int i = 0; i < x; i++) {
			Trees.add(new ArrayList<ArrayList<Tree>>());
			for(int j = 0; j < x; j++) {
				Trees.get(i).add(new ArrayList<Tree>());
			}
		}
	}
	
	// 양분값 인풋 후 리턴 메소드.
	private static int[][] InEnergy(int n, int e){
		int[][] eArr = new int[n][n];
		
		for(int i = 0; i < n; i++) Arrays.fill(eArr[i], e);
		
		return eArr;
	}
	
	// 좌표에 나무 인풋 메소드.
	private static void InTree(int x, int y, int age) {
		Trees.get(x- 1).get(y- 1).add(new Tree(age));
	}
	
	// 좌표 나무s 영양분 섭취 및 나이 증가.
	private static void Intake(int x, int y){
		
		boolean tFlag = true;
		ArrayList<Tree> tmpArr = Trees.get(x).get(y);
		for(int i = 0; i < tmpArr.size(); i++) {
			
			if(tFlag && Energy[x][y] >= tmpArr.get(i).age) {
				Energy[x][y] -= tmpArr.get(i).age;
				tmpArr.get(i).age++;
			
			//(나이에 비해 양분섭취 못할 시 죽음(제거) 및 나이/2 양분 추가)
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
	
	// 나무 번식 메소드.
	private static void Planting(int x, int y) {
		ArrayList<Tree> tmpList = Trees.get(x).get(y);
		
		for(int i = 0; i < tmpList.size(); i++) {
			if(tmpList.get(i).age % 5 != 0) continue;
			// 필드 영역 체크
			for(int tx = -1; tx < 2; tx++) {			
				for(int ty = -1; ty < 2; ty++) {
					if(tx == 0 && ty == 0) continue;
					if(!CheckFieldSize(x, y, tx, ty)) continue;
					// 나이가 1인 나무 생성.
					Trees.get(x + tx).get(y + ty).add(new Tree(1));
				}
			}
			
		}

	}
	
	// 필드 사이즈 체크 메소드.
	private static boolean CheckFieldSize(int x, int y, int tx, int ty) {
		if((x + tx) < 0 || Trees.size() < (x + tx)) return false;
		if((y + ty) < 0 || Trees.size() < (y + ty)) return false;
		
		return true;
	}

	// S2D2 양분 추가 메소드.
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
				// 나이 오름차순으로 정렬.
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
	
	// 나무 전체 값 출력.
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












