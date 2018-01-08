fun main(args: Array<String>)
{
	var Lreal : Double = Math.PI
	var Real : Float = Math.PI.toFloat()
	var Lint : Long = 123
	var DInt : Int = 123
	var Int2 : Short = 123
	var Sint : Byte = 123
	var Bool : Boolean = true
	var arr1 = arrayOf(1,2,3)
	var arr2 = arrayOfNulls<Double>(3)
	var arr3 = Array<Double>(3,{i: Int -> (i * Math.PI) })
	var str : String = "Hello World!"

	println(Lreal) //3.141592653589793
	println(Real) //3.1415927
	println(Lint) //123
	println(DInt) //123
	println(Int2) //123
	println(Sint) //123
	println(Bool) //true

	println(arr1[1]) //2
	println(arr2[1]) //null
	println(arr3[1]) //3.141592653589793
	println(str) //Hello World!
	println("theApp Print $str , the length is ${str.length}") //theApp Print Hello World! , the length is 12
}
