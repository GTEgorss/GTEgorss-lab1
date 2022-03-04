import com.sun.jna.Library;
import com.sun.jna.Native;

public class lab_1_1 {
    public interface MyMath extends Library {
        int sum(int a, int b);

        int mult();
    }

    public static void main(String[] args) {
        MyMath lib = Native.load("libCsharp_interop1.dylib", MyMath.class);
        System.out.println(lib.sum(1, 2));
        System.out.println(lib.mult());
    }
}
