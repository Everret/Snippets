//xml
<?xml version="1.0" encoding="utf-8"?>
<android.support.constraint.ConstraintLayout xmlns:android="http://schemas.android.com/apk/res/android"
    xmlns:app="http://schemas.android.com/apk/res-auto"
    xmlns:tools="http://schemas.android.com/tools"
    android:layout_width="match_parent"
    android:layout_height="match_parent"
    tools:context="com.example.zhukov.myapp.MainActivity">

    <LinearLayout
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:orientation="vertical">
        <TextView
            android:id="@+id/textview1"
            android:text="Hello World!"
            android:textSize="30pt"
            android:layout_width="match_parent"
            android:layout_height="match_parent" />

        <Button
            android:id="@+id/theButton"
            android:layout_width="match_parent"
            android:layout_height="match_parent"
            android:onClick="ButtononClick"
            android:text="@string/name"
            android:textSize="20pt" />
    </LinearLayout>
</android.support.constraint.ConstraintLayout>


//build.gradle(Module:app)加入下面这句
apply plugin: 'kotlin-android-extensions'



//kt
package com.example.zhukov.myapp

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.view.View //很重要，添加当前View
import kotlinx.android.synthetic.main.activity_main.* //很重要，这样才能读到控件名称


class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

	//这是点击事件的实现函数，必须使用public
    public fun ButtononClick(v: View?)
    {
    	//直接使用控件名，再使用相应属性更改即可
        textview1.text = ((Math.random()*10000).toInt()).toString()
    }
}
