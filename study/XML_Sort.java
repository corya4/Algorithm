package help;

import java.io.File;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.TreeSet;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.w3c.dom.Element;



public class XML_Sort {
	
	static List<String> flightList = Arrays.asList("KAL12", "KAL02", "KAL12", "JAL23", "ANA13", "KAL05", "JAL01", "ANA03", "JAL23", "JAL05", "ANA03", "ANA25");
	static TreeSet<Map<String, List<String>>> tree;
	
	static String path = "C:\\Users\\corya\\Documents\\saved.xml";
							// ㄴ 개인PC 경로로 수정 or 동적경로
	
	public static void main(String[] args) {
		
		init();
		createFile();
		
	}
	
	public static void init() {
		tree = new TreeSet<Map<String, List<String>>>(new Comparator<Map<String, List<String>>>() {
			@Override
			public int compare(Map<String, List<String>> o1, Map<String, List<String>> o2) {
				return o1.keySet().iterator().next().toString().compareTo(o2.keySet().iterator().next().toString());
			}
		});
		
		
		for(String value : flightList) {
			String key = value.substring(0, 3);
			if(containMap(key, tree)) {
				addMap(key, value, tree);
			}else {
				Map<String, List<String>> m = new HashMap<String, List<String>>();
				ArrayList<String> list = new ArrayList<String>();
				m.put(key, list);
				tree.add(m);
			}
		}
		
		sortMap(tree);
		
		System.out.println("=======================정렬===========================");
		System.out.println(tree);
		System.out.println("======================================================");
		System.out.println();
	}
	
	public static void sortMap(TreeSet<Map<String, List<String>>> set) {
		for(Map<String, List<String>> t_map : set) {
			Iterator<String> iter = t_map.keySet().iterator();
			
			t_map.get(iter.next()).sort(new Comparator<String>() {
				@Override
				public int compare(String o1, String o2) {
					int i1 = Integer.parseInt(o1.substring(3, o1.length()-1));
					int i2 = Integer.parseInt(o2.substring(3, o2.length()-1));
				return i1 - i2;
				}
			});
				
		}
		
	}
	
	public static boolean containMap(String key, TreeSet<Map<String, List<String>>> set) {
		for(Map<String, List<String>> t_map : set) {
			if(t_map.get(key) != null) {
				return true;
			}
		}
		return false;
	}

	public static void addMap(String key, String value, TreeSet<Map<String, List<String>>> set) {
		for(Map<String, List<String>> t_map : set) {
			if(t_map.get(key) != null) {
				 t_map.get(key).add(value);
			}
		}
	}
	
	public static void createFile() {
		
		Document doc = null;
		try {
			DocumentBuilderFactory factory = null;
			factory = DocumentBuilderFactory.newInstance();
			DocumentBuilder builder = null;
			builder = factory.newDocumentBuilder();
			doc = builder.newDocument();
		} catch (ParserConfigurationException e) {
			e.printStackTrace();
		}
		
		Element root = doc.createElement("Root");
		Element fightInfo = doc.createElement("fightInfo");
		Element item = null;
		
		for(Map<String, List<String>> t_map : tree) {
			item = doc.createElement("item");
			
			Element company = doc.createElement("company");
			
			String strCompany = t_map.keySet().iterator().next().toString();
			company.setTextContent(strCompany);
			
			Element fights = doc.createElement("fights");
			
			for(String ctn : t_map.get(strCompany)) {
				Element fightName = doc.createElement("fightName");
				fightName.setTextContent(ctn);
				fights.appendChild(fightName);
			}
			
			item.appendChild(company);
			item.appendChild(fights);
			fightInfo.appendChild(item);
		}
		
		
		root.appendChild(fightInfo);
		doc.appendChild(root);
		
		DOMSource xmlDOM = new DOMSource(doc);
		StreamResult xmlFile = new StreamResult(new File(path)); 
		try {
			TransformerFactory.newInstance().newTransformer().transform(xmlDOM, xmlFile);
			System.out.println("파일 생성 완료");
		} catch (Exception e) {
			e.printStackTrace();
		}

	}
}






