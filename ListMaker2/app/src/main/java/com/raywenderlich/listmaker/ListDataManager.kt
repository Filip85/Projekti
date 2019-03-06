package com.raywenderlich.listmaker

import android.content.Context
import android.nfc.Tag
import android.preference.PreferenceManager
import android.util.Log

class ListDataManager(val context: Context) {
    fun saveList(list: TaskFile) { //za pohranu liste //objekt tipa TaskFile

        // uzmi referencu deafultnog SharedReference filea i pomocu .Edit() omoguci upisivanje kljucnih parametara u SharedPreference
        val sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context).edit()

        //za spremanje liste (TaskFile, klasa) u sharedPreference kao string; kako je tasks (u TaskFile-u) array stringova tada ne možemo pohraniti drektno u string. Moramo convertati tasks u TaskFile-u u HashSet koji možemo prosljediti kao vrijednost kako bi se sejvala
        sharedPreferences.putStringSet(list.name, list.tasks.toHashSet())

        //upisivanje u listu sharedPreference
        sharedPreferences.apply()
        }

    fun readList(): ArrayList<TaskFile>{

        //uzmi referencu od defaultnog SharedPreference file-a, ne treba SharedPreference.Edit posto treba samo citati iz file-a
        val sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context)

        //uzima se content (set of items) SharedPreference file kao mapa
        val sharedPreferencesContent = sharedPreferences.all

        //kreira se prazna lista (ArrayList) tipa TaskFile (kao klasa) koja ce sluziti za pohranu liste koju ce vratiti SharedPrefernece
        val taskLists = ArrayList<TaskFile>()


        //iterira po svim mapama koje smo primili od SharedPreference koristeći for petlju
        for (taskList in sharedPreferencesContent) {

            //u svakoj iteraciji uzima vrijednost objekta, casta ga u HashSet<String>
            val itemHashSet = taskList.value as HashSet<String>

            //rekreira list objekt prosljeđujući key od sharedPreference objekta kao imena TaskLista i converta HashSet u ArrayList taskova (natrag u strukturirani objekt)
            val list = TaskFile(taskList.key, ArrayList(itemHashSet))

            //dodaje novo rekonstruiranu listu u praznu Array listu taskLists
            taskLists.add(list)
        }

        return taskLists
    }
}