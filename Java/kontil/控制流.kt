fun main(args: Array<String>) {
	var max = 10
	//if语句
	if (max > 20) {
		max = 30
	}
	else {
		max = 20
	}
	println(max)

	//if表达式
	var min = if (max > 3) {
		4
	}
	else {
		2
	}

	//switch语句
	when (min) {
		1 -> println(1)
		2 -> println(2)
		in 11..20-> println(6)
		!in 3..10-> println(5)
		else -> {
			println(3)
		}
	}

	var arr = arrayOf(3,5,6)
	for (i in arr)
	{
		println(i)
	}

	while (arr[0] > 0)
	{
		arr[1]--
	}

	do {
		arr[2]--
	}while (arr[0] > 0)

}
