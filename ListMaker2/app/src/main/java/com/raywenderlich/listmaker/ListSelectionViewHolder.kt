package com.raywenderlich.listmaker

import android.os.Parcel
import android.os.Parcelable
import android.support.v7.widget.RecyclerView
import android.view.View
import android.widget.TextView

class ListSelectionViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView){
    val listPosition = itemView?.findViewById<TextView>(R.id.itemNuber) as TextView

    val listTitle = itemView?.findViewById<TextView>(R.id.itemString) as TextView


}
