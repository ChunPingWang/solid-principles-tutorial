package bad;

/**
 * ❌ 違反 SRP：Employee 類別同時負責了「員工資料管理」、「薪資計算」和「資料儲存」三件事。
 * 當其中任何一個需求改變時，都必須修改這個類別，造成維護困難。
 */
public class Employee {
    private String name;
    private double baseSalary;

    public Employee(String name, double baseSalary) {
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public String getName() {
        return name;
    }

    public double getBaseSalary() {
        return baseSalary;
    }

    // 責任 1：計算薪資（應該由薪資計算模組負責）
    public double calculatePay() {
        return baseSalary * 1.1; // 加上 10% 獎金
    }

    // 責任 2：產生報表（應該由報表模組負責）
    public String generateReport() {
        return "員工: " + name + ", 薪資: " + calculatePay();
    }

    // 責任 3：儲存到資料庫（應該由資料存取模組負責）
    public void saveToDatabase() {
        System.out.println("將 " + name + " 的資料儲存到資料庫...");
        // 假裝儲存到資料庫
    }
}
