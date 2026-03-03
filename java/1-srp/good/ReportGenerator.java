package good;

/**
 * ✅ 遵循 SRP：ReportGenerator 只負責產生報表。
 */
public class ReportGenerator {
    public String generateReport(Employee employee, double pay) {
        return "員工: " + employee.getName() + ", 薪資: " + pay;
    }
}
