package good;

/**
 * ✅ 遵循 SRP：EmployeeRepository 只負責資料儲存。
 */
public class EmployeeRepository {
    public void save(Employee employee) {
        System.out.println("將 " + employee.getName() + " 的資料儲存到資料庫...");
    }
}
