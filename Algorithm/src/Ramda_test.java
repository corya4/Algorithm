import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.Random;
import java.util.stream.IntStream;
import java.util.stream.Stream;

class Students implements Comparable<Students>{
	
	Students(int m, int l, int e){
		math = m;
		language = l;
		english = e;
	}
	private int math;
	private int language;
	private int english;
	public int getMath() {
		return math;
	}
	public void setMath(int math) {
		this.math = math;
	}
	public int getLanguage() {
		return language;
	}
	public void setLanguage(int language) {
		this.language = language;
	}
	public int getEnglish() {
		return english;
	}
	public void setEnglish(int english) {
		this.english = english;
	}
	@Override
	public int compareTo(Students o) {
		int ave1 = o.getEnglish() + o.getLanguage() + o.getMath();
		int ave2 = this.getEnglish() + this.getLanguage() + this.getMath();
		return ave2 - ave1;
	}
	@Override
	public String toString() {
		return "Students [math=" + math + ", language=" + language + ", english=" + english + "]";
	}
	
	
}

public class Ramda_test {

	public static void main(String[] args) {
		
		ArrayList<Students> sList = new ArrayList<Students>();
		Students a = new Students(50, 70, 30);
		Students b = new Students(100, 20 , 20);
		Students c = new Students(60,50,70);
		
		sList.add(a); sList.add(b); sList.add(c);
		
		Stream<Students> re = sList.stream().sorted(Comparator.naturalOrder());
		re.forEach(System.out::println);
		String a1 = "9334330";
		String a2 = "9330343";
		System.out.println(a2.compareTo(a1));
	}

}
















