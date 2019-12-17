package hm.soultion7.solution7;
import java.io.*;
import java.util.Locale;
import java.util.Scanner;

public class solution7 {
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
        String file = scanner.nextLine();
        BufferedReader reader = new BufferedReader(new FileReader(file));
        while(true) {
            int max = 0;
            String line;
            while ((line = reader.readLine()) != null) {
                line = line.substring(0, 8);
                line = line.replaceAll("\\s+","");
                if (Integer.parseInt(line) > max)
                    max = Integer.parseInt(line);
            }
            String[] a = scanner.nextLine().split(" ");
            if (a[0].contains("-c")) {
                int nomer = max + 1;
                float f = Float.parseFloat(a[2]);
                String str = String.format(Locale.US,"%-8s%-30s%-8.2f%-4s",nomer,a[1],f,a[3]);
                PrintWriter fw = new PrintWriter(new FileWriter(file, true));
                fw.println(str);
                fw.close();
            }
        }
    }
}
