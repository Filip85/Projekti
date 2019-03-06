package com.raywenderlich.listmaker

import android.os.Bundle
import android.os.Parcel
import android.os.Parcelable
import android.support.design.widget.Snackbar
import android.support.v7.app.AlertDialog
import android.support.v7.app.AppCompatActivity
import android.support.v7.widget.GridLayoutManager
import android.support.v7.widget.LinearLayoutManager
import android.support.v7.widget.RecyclerView
import android.text.InputType
import android.view.Menu
import android.view.MenuItem
import android.widget.EditText

import kotlinx.android.synthetic.main.activity_main.*
import org.intellij.lang.annotations.JdkConstants

class MainActivity() : AppCompatActivity(){
    lateinit var listRecyclerView: RecyclerView
    val listDataManager: ListDataManager = ListDataManager(this)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        setSupportActionBar(toolbar)

        fab.setOnClickListener { view ->
            showCreateListDialog()
        }

        val lists = listDataManager.readList()

        listRecyclerView = findViewById<RecyclerView>(R.id.list_recyclerview)
        listRecyclerView.layoutManager = LinearLayoutManager(this)
        listRecyclerView.adapter = ListSelectionAdapterRecyclerViewAdapter(lists)
    }

    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        // Inflate the menu; this adds items to the action bar if it is present.
        menuInflater.inflate(R.menu.menu_main, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        return when (item.itemId) {
            R.id.action_settings -> true
            else -> super.onOptionsItemSelected(item)
        }
    }

    //za kreiranje novih elemenata u listi
    private fun showCreateListDialog() {
        val dialogTitle = getString(R.string.name_of_list);            //za dohvacanja What is the name of your list iz string.xml
        val positiveButtonTitle = getString(R.string.create_list)      //za dohvacanje Create iz string.xml

        val builder = AlertDialog.Builder(this);  //za kreiranje dialoga (ono sto ce iskociti kada se stisne na + gumbic
        val listTitleEditText = EditText(this);                // za kreiranje prostora gdje ce se unositi ime liste
        listTitleEditText.inputType = InputType.TYPE_CLASS_TEXT       //stavljamo da unos u listTitleEditText bude tekst, a ne brojke

        builder.setTitle(dialogTitle)                                  //ispis What is the name of your list? u tom dialogu koji iskoci
        builder.setView(listTitleEditText)                             //ispis Createa u tom dialogu koji iskoci

        builder.setPositiveButton(positiveButtonTitle, { dialog, i ->
            val list = TaskFile(listTitleEditText.text.toString())
            listDataManager.saveList(list)

            val recyclerAdapter = listRecyclerView.adapter as ListSelectionAdapterRecyclerViewAdapter

            recyclerAdapter.addList(list)

            dialog.dismiss()
        })

        builder.create().show()
    }
}

