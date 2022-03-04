import scala.collection.immutable

object ScalaFor {
  def foo(n: Int, v: Int): immutable.IndexedSeq[(Int, Int)] =
    for (i <- 0 until n;
         j <- i until n if i + j == v)
      yield (i, j)
}
