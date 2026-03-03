package good;

/**
 * ✅ 遵循 SRP：PayCalculator 只負責薪資計算。
 */
public class PayCalculator {
    public double calculatePay(Employee employee) {
        return employee.getBaseSalary() * 1.1; // 加上 10% 獎金
    }
}
