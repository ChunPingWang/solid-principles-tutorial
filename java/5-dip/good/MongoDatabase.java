package good;

public class MongoDatabase implements Database {
    @Override
    public void save(String data) {
        System.out.println("儲存到 MongoDB: " + data);
    }
}
