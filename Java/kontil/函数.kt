fun main(args: Array<String>) 
{
    println(sum(3,4).toString())
    mul(5,6)
    sub(7,1)
}

//返回Int类型
fun sum(a: Int, b: Int) : Int 
{
    return a + b
}

//无返回值，可以省略Unit
fun sub(a: Int,b: Int)
{
    println((a-b).toString())
}


