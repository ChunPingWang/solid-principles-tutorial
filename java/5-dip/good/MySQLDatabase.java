package good;

public class MySQLDatabase implements Database {
    @Override
    public void save(String data) {
        System.out.println("儲存到 MySQL: " + data);
    }
}
