import scala.Function1;
import scala.Tuple2;
import scala.collection.immutable.IndexedSeq;
import scala.runtime.BoxesRunTime;
import scala.runtime.RichInt.;

public final class ScalaFor$ {
    public static ScalaFor$ MODULE$;

    static {
        new ScalaFor$();
    }

    public IndexedSeq<Tuple2<Object, Object>> foo(final int n, final int v) {
        return (IndexedSeq).MODULE$.until$extension0(scala.Predef..MODULE$.intWrapper(0), n).flatMap((i) -> {
            return $anonfun$foo$1(n, v, BoxesRunTime.unboxToInt(i));
        }, scala.collection.immutable.IndexedSeq..MODULE$.canBuildFrom());
    }

    private ScalaFor$() {
        MODULE$ = this;
    }
}
