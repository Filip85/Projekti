package com.raywenderlich.listmaker

import android.os.Parcel
import android.os.Parcelable
import android.support.v7.widget.RecyclerView
import android.view.LayoutInflater
import android.view.ViewGroup

class ListSelectionAdapterRecyclerViewAdapter(val lists: ArrayList<TaskFile>) : RecyclerView.Adapter<ListSelectionViewHolder>()
{
    var listTitles = arrayOf("Shopping list", "Chores", "Android Tutorials")

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ListSelectionViewHolder {
        val view = LayoutInflater.from(parent?.context)
                .inflate(R.layout.list_selectin_view_holder,
                        parent,false)

        return ListSelectionViewHolder(view);
    }

    override fun getItemCount(): Int {
        return lists.size
    }

    override fun onBindViewHolder(holder: ListSelectionViewHolder, position: Int) {
        if (holder != null) {
            holder.listPosition.text = (position + 1).toString()
            holder.listTitle.text = lists.get(position).name;
        }
    }

    fun addList(list: TaskFile) {
        lists.add(list)

        notifyDataSetChanged()
    }

}