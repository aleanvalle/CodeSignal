import java.util.*;

public class CheckPalindrome{
	boolean solution(String inputString){
		int lengthOfString = inputString.length();
		if (lengthOfString == 1){
			return true;
		}
		int firstHalfDiff = lengthOfString / 2;
		int secondHalfDiff = lengthOfString - firstHalfDiff;
		String firstHalf = inputString.substring(0, firstHalfDiff);
		String secondHalfReversed = inputString.substring(secondHalfDiff, lengthOfString);
		String secondHalf = new StringBuilder(secondHalfReversed).reverse().toString();
		return firstHalf.equals(secondHalf);
	}
	public static void main(String[] args){
		CheckPalindrome a = new CheckPalindrome();
		System.out.println("otto: "+a.solution("otto"));
		System.out.println("z: "+a.solution("z"));
		System.out.println("reconocer: "+a.solution("reconocer"));
		System.out.println("arenera: "+a.solution("arenera"));
		System.out.println("memmem: "+a.solution("memmem"));
		System.out.println("narran: "+a.solution("narran"));
		System.out.println("selles: "+a.solution("selles"));
		System.out.println("bc: "+a.solution("bc"));
		System.out.println("zzz: "+a.solution("zzz"));
		System.out.println("pepe: "+a.solution("pepe"));
		System.out.println("sometemos: "+a.solution("sometemos"));
		System.out.println("adannocedeconevayyavenocedeconnada: "+a.solution("adannocedeconevayyavenocedeconnada"));
	}
}
