import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String inputLine = scanner.nextLine();

        String protocol = "";
        String server = "";
        String resource = "";
        String serverResource = inputLine;

        if (inputLine.contains("://")) {
            protocol = inputLine.split("://")[0];
            serverResource = inputLine.split("://")[1];
        }
        if (serverResource.contains("/")) {
            server = serverResource.substring(0, serverResource.indexOf('/'));
            resource = serverResource.substring(serverResource.indexOf('/') + 1);
        }
        else {
            server = serverResource;
        }
        System.out.printf("[protocol] = \"%s\"", protocol);
        System.out.println();
        System.out.printf("[server] = \"%s\"", server);
        System.out.println();
        System.out.printf("[resource] = \"%s\"", resource);
    }
}
