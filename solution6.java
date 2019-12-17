package hm.soultion7.solution7;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class solution6 {
    public static void main(String[] args) throws IOException {
        Scanner scanner1 = new Scanner(System.in);
        String[] a = scanner1.nextLine().split(" ");
        if (a[0].contains("e")) {
            List<String> list = new ArrayList();
            BufferedReader reader = new BufferedReader(new FileReader(a[1]));
            List<Byte>means = new ArrayList();
            String line;
            while((line = reader.readLine()) !=null) {
                list.add(line);
            }
            reader.close();
            PrintWriter writer = new PrintWriter(a[2], "UTF-8");
            for(int k = 0; k < list.size(); ++k) {
                byte[] utf8Bytes = list.get(k).getBytes("UTF-8");
                for(int i = 0; i < utf8Bytes.length; ++i) {
                    means.add(utf8Bytes[i]);
                    System.out.println(utf8Bytes[i]);
                    writer.println(utf8Bytes[i]);
                }
            }
            writer.close();
        }
        else if (a[0].contains("d")) {
            BufferedReader reader = new BufferedReader(new FileReader(a[1]));
            String line;
            PrintWriter writer = new PrintWriter(a[2], "UTF-8");
            while((line = reader.readLine()) !=null) {
                writer.write((char)Byte.parseByte(line));
            }
            reader.close();
            writer.close();
        }
    }
}
