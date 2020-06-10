package study;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

import javax.swing.JFrame;

class KeyListener extends KeyAdapter {
	static Game2048 game;
	static boolean flag = false;

	KeyListener(Game2048 table) {
		game = table;
	}

	@Override
	public void keyPressed(KeyEvent e) {
		int jump = 1;
		if (game.checking()) {
			if (e.getKeyChar() == 'y') {
				game.setting();
				print();
			} else if (e.getKeyChar() == 'n') {
				System.out.println("終了します。");
				System.exit(0);
			}
			game.result = true;
		} else {
			game.result = false;
			if (e.getKeyChar() == 'j') {
				for (int i = 0; i < game.table.length; i++) {
					for (int j = 1; j < game.table[i].length; j++) {
						if (game.table[i][j - 1].equals(".")) { // 판별할 위치 앞의 값이 비어있다면
							if (game.table[i][j].equals(".")) { // 자기 위치의 값도 비어있다면
								jump++; // 이동 범위값 증가
							} else { // 자기 위치에 값이 존재한다면 자리 이동
								game.table[i][j - jump] = game.table[i][j];
								game.table[i][j] = "."; // 이동한 위치값 초기화
							}
						} else { // 판별할 위치 앞의 값이 존재한다면
							if (game.table[i][j - 1].equals(game.table[i][j])) { // 앞의 값과 같다면 숫자를 합치고 자리 이동
								game.table[i][j - 1] = Integer.parseInt(game.table[i][j])
										+ Integer.parseInt(game.table[i][j - 1]) + "";
								game.table[i][j] = "."; // 이동한 위치 값 초기화
							}
						}
						if (j - jump > 0) { // 앞 비교문에서 숫자가 합쳐지고 난후, 그 뒤에 온 숫자가 같은지 판단하는 비교문 입니다.
							if (game.table[i][j - jump - 1].equals(game.table[i][j - jump])) { // 뒤에서이동해온 값이 앞의 값과 같다면
																								// 합침.
								game.table[i][j - jump - 1] = Integer.parseInt(game.table[i][j - jump - 1])
										+ Integer.parseInt(game.table[i][j - jump]) + "";
								game.table[i][j - jump] = ".";
								j -= jump;// 그후 합쳐진 값과 그 앞의 값이 같은지 판단하기 위해 반복값 수정
								jump = 1;
							}
						}
					}
					jump = 1;// 초기화
				}
			} else if (e.getKeyChar() == 'l') {
				for (int i = 0; i < game.table.length; i++) {
					for (int j = game.table[i].length - 2; j >= 0; j--) {
						if (game.table[i][j + 1].equals(".")) {
							if (game.table[i][j].equals(".")) {
								jump++;
							} else {
								game.table[i][j + jump] = game.table[i][j];
								game.table[i][j] = ".";
							}
						} else {
							if (game.table[i][j + 1].equals(game.table[i][j])) {
								game.table[i][j + 1] = Integer.parseInt(game.table[i][j])
										+ Integer.parseInt(game.table[i][j + 1]) + "";
								game.table[i][j] = ".";
							}
						}
						if (j + jump < game.table.length - 1) {
							if (game.table[i][j + jump + 1].equals(game.table[i][j + jump])) {
								game.table[i][j + jump + 1] = Integer.parseInt(game.table[i][j + jump + 1])
										+ Integer.parseInt(game.table[i][j + jump]) + "";
								game.table[i][j + jump] = ".";
								j += jump;
								jump = 1;
							}
						}
					}
					jump = 1;
				}
			} else if (e.getKeyChar() == 'i') {
				for (int i = 0; i < game.table[0].length; i++) {
					for (int j = 1; j < game.table.length; j++) {
						if (game.table[j - 1][i].equals(".")) {
							if (game.table[j][i].equals(".")) {
								jump++;
							} else {
								game.table[j - jump][i] = game.table[j][i];
								game.table[j][i] = ".";
							}
						} else {
							if (game.table[j - 1][i].equals(game.table[j][i])) {
								game.table[j - 1][i] = Integer.parseInt(game.table[j - 1][i])
										+ Integer.parseInt(game.table[j][i]) + "";
								game.table[j][i] = ".";
							}
						}
						if (j - jump > 0) {
							if (game.table[j - jump - 1][i].equals(game.table[j - jump][i])) {
								game.table[j - jump - 1][i] = Integer.parseInt(game.table[j - jump - 1][i])
										+ Integer.parseInt(game.table[j - jump][i]) + "";
								game.table[j - jump][i] = ".";
								j -= jump;
								jump = 1;
							}
						}
					}
					jump = 1;
				}
			} else if (e.getKeyChar() == 'k') {
				for (int i = 0; i < game.table[0].length; i++) {
					for (int j = game.table.length - 2; j >= 0; j--) {
						if (game.table[j + 1][i].equals(".")) {
							if (game.table[j][i].equals(".")) {
								jump++;
							} else {
								game.table[j + jump][i] = game.table[j][i];
								game.table[j][i] = ".";

							}
						} else {
							if (game.table[j + 1][i].equals(game.table[j][i])) {
								game.table[j + 1][i] = Integer.parseInt(game.table[j][i])
										+ Integer.parseInt(game.table[j + 1][i]) + "";
								game.table[j][i] = ".";
							}
						}
						if (j + jump < game.table.length - 1) {
							if (game.table[j + jump + 1][i].equals(game.table[j + jump][i])) {
								game.table[j + jump + 1][i] = Integer.parseInt(game.table[j + jump + 1][i])
										+ Integer.parseInt(game.table[j + jump][i]) + "";
								game.table[j + jump][i] = ".";
								j += jump;
								jump = 1;
							}
						}
					}
					jump = 1;
				}
			} else if (e.getKeyChar() == 'q') {
				System.out.println("終了します。");
				System.exit(0);
			} else {
				System.out.println("再入力してください。");
				return;
			}

			while (true) {
				int x = game.random("t");
				int y = game.random("t");
				if (game.table[x][y].equals(".")) { // 비어있는 자리라면 숫자 추가후 반복문 탈출
					game.table[x][y] = game.box[game.random("b")];
					break;
				}
			}
			print();
		}

	}

	static void print() { // 게임 상황 출력 메소드
		for (String[] line : game.table) {
			for (String number : line) {
				System.out.print((number.length() > 1) ? number + "  " : " " + number + "  "); // true일때 문자열 그대로,
																								// false일때 " "+해서 출력
			}
			System.out.println();
		}
		System.out.println();
	}
}

public class Game2048 extends JFrame {
	static String[][] table = new String[4][4]; // 게임 테이블
	static String[] box = { "2", "2", "2", "2", "2", "2", "2", "1", "1", "4" }; // 랜덤으로 숫자를 꺼내오는 배열
	static boolean result = false;
	static KeyListener key;

	public Game2048() {
		key = new KeyListener(this);
		setting();
		key.print();
		this.addKeyListener(key);
		setSize(100, 100);
		setLocation(0, -150);
		setResizable(false);
		setVisible(true);
	}

	static int random(String choice) { // 상황에 맞게 랜덤으로 숫자를 뽑아오게 할 메소드
		int r = 0;

		if (choice.equals("s")) {
			r = (int) (Math.random() * 9);
		} else if (choice.equals("t")) {
			r = (int) (Math.random() * table.length);
		} else if (choice.equals("b")) {
			r = (int) (Math.random() * 10);
		}
		return r;
	}

	static void setting() {
		for (int i = 0; i < table.length; i++) {
			for (int j = -0; j < table[i].length; j++) { // 이중배열을 반복합니다.
				table[i][j] = "."; // 초기에 . 으로 초기화
			}
		}
		for (int z = 0; z < 2; z++) { // 두개의 숫자를 랜덤자리에 배치
			if (!table[random("t")][random("t")].equals(".")) { // 만약 같은자리에 입력된다면 반복횟수를 한번 줄이고 continue
				z--;
				continue;
			}
			table[random("t")][random("t")] = box[random("s")]; // 숫자 입력
		}
	}

	static boolean checking() { // 승패 여부 메소드
		int space = 1;
		for (String[] line : table) {
			for (String num : line) {
				if (num.equals("2048")) { // 이중반복문 안에 문자열 2048이 존재하면 플에이어 승
					if (!result) {
						System.out.println("勝利しました。");
						System.out.println("ゲームを復始めますか。　（Y/N) >> ");
					}
					return true;
				}
				if (!num.equals(".")) { // 빈 공간 수 체크
					space++;
				}
			}
		}
		if (space > 16) { // 빈 공간이 없다면 플에이어 패배
			if (!result) {
				System.out.println("敗北しました。");
				System.out.println("ゲームを復始めますか。　（Y/N) >> ");
			}
			return true;
		}
		return false;
	}

	public static void main(String[] args) {
		new Game2048();
	}

}
