import java.io.Console;
import java.lang.reflect.Array;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;


import static java.lang.System.in;

public class AverageGrades {
     static class Student {
        private String Name;
        private double Avarage;

        public String getName() {
            return Name;
        }

        public void setName(String name) {
            Name = name;
        }

        public Double getAvarage() {
            return Avarage;
        }

        public void setAvarage(Double avarage) {
            Avarage = avarage;
        }

        @Override
         public String toString() {
            return Name + " -> " + Avarage;
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
     //   DecimalFormat df = new DecimalFormat("#.00");
        int count = Integer.parseInt(scanner.nextLine());
        ArrayList<Student> students = new ArrayList<>();

        for (int i = 1; i <= count; i++) {

            String[] tokens = scanner.nextLine().split(" ");

            String name = tokens[0];
            ArrayList<Double> grades = new ArrayList<>();

            for (int j = 1; j < tokens.length; j++) {
                grades.add(Double.parseDouble(tokens[j]));
            }

            double sum = 0;

            for (int j = 0; j < grades.size(); j++) {
                sum += grades.get(j);
            }

            double average = sum / grades.size();

            Student student = new Student();
            student.Name = name;
            student.Avarage = average;
            students.add(student);
        }


        removeWeakStudents(students, 5.00);

//        sortByNameDescending(students);
//
//        sortByAverageDescending(students);
        sortByNameAndAge(students);

        print(students);




    }

    public static void sortByNameDescending(ArrayList<Student> students) {
        students.sort((student, other) -> student.getName().compareTo(other.getName()));
    }

    public static void sortByAverageDescending(ArrayList<Student> students) {
         students.sort((student, other) -> student.getAvarage().compareTo(other.getAvarage()));
    }

    public static void sortByNameAndAge(ArrayList<Student> students) {
        Collections.sort(students, new Comparator<Student>() {
            @Override
            public int compare(Student o1, Student o2) {
                String s1 = o1.getName();
                String s2 = o2.getName();

                int temp = s1.compareTo(s2);


                if (temp != 0) {
                    Double d1 = o1.getAvarage();
                    Double d2 = o2.getAvarage();
                    return d1.compareTo(d2);

                }
                else if (temp == 0 && s1.equals(s2)) {
                    return o2.getAvarage().compareTo(o1.getAvarage());
                } else {
                    return temp;
                }
            }
        });
    }

    public static void sortByAverageAscending(ArrayList<Student> students) {
        students.sort((student, other) -> other.getAvarage().compareTo(student.getAvarage()));
    }

    public static void removeWeakStudents(ArrayList<Student> students, double minGrade) {
        for (int i = 0; i < students.size(); i++) {
            if (students.get(i).getAvarage() < minGrade) {
                students.remove(i);
            }
        }
    }

    public static void print(ArrayList<Student> students) {
        for (Student student : students) {
            System.out.printf("%s -> %.2f\n", student.getName(), student.getAvarage());
        }
     }


}
