import org.openjdk.jmh.runner.Runner;
import org.openjdk.jmh.runner.options.*;
import src.main.java.*;

public class lab_1_4 {
    public static void main(String[] args) throws Exception {
        Options options = new OptionsBuilder()
                .include(Sort.class.getSimpleName())
                .forks(1)
                .warmupIterations(0)
                .measurementIterations(7)
                .build();
        new Runner(options).run();
    }
}
