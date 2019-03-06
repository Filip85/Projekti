package com.raywenderlich.timefighter

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.os.CountDownTimer
import android.util.Log
import android.widget.Button
import android.widget.TextView
import android.widget.Toast

class GameActivity : AppCompatActivity() {
    internal val TAG = GameActivity::class.java.simpleName;
    internal lateinit var gameScoreTextView: TextView;
    internal lateinit var timeLeftTextView: TextView;
    internal lateinit var tapMeButton: Button;
    internal var score = 0;

    internal var gameStarted = false;

    internal lateinit var countDownTimer: CountDownTimer;
    internal var initialCountDown : Long = 60000;
    internal var countDownInternal : Long = 1000;
    internal var timeLeft = 60;

    companion object {
        private val SCORE_KEY = "SCORE_KEY";

        private  val TIME_LEFT_KEY = "TIME_LEFT_KEY";
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_game)

        Log.d(TAG, "onCreate : $score")

        //Log.d(TAG, savedInstanceState.getInt(SCORE_KEY).toString());
        gameScoreTextView = findViewById < TextView >(R.id.game_score_text_view);
        timeLeftTextView = findViewById<TextView>(R.id.time_left_text_viwe);
        tapMeButton = findViewById<Button>(R.id.tap_me_button);

        tapMeButton.setOnClickListener{v -> incrementScore()};

        if(savedInstanceState != null){
            score = savedInstanceState.getInt(SCORE_KEY);
            timeLeft = savedInstanceState.getInt(TIME_LEFT_KEY);
            restoreGame();
        }
        else {
            resetGame();
        }
    }

    override fun onSaveInstanceState(outState : Bundle) {

        super.onSaveInstanceState(outState);
        outState.putInt(SCORE_KEY, score);
        outState.putInt(TIME_LEFT_KEY, timeLeft);
        countDownTimer.cancel();

        //this.score = outState.getInt(SCORE_KEY);

        Log.d(TAG, "onSaveInstanceState: Saving Score: $score & Time Left: $timeLeft");
        //Log.d(TAG, "onSaveInstanceState: Saving Score: "+ outState.get(SCORE_KEY));



    }

    override fun onDestroy(){
        super.onDestroy();
        countDownTimer.cancel();
        Log.d(TAG, "onDestroy called.");
    }

    private fun incrementScore(){
        score++;

        /*val newScore = "Your Score: " + Integer.toString(score);
        gameScoreTextView.text = newScore;*/

        val newScore = getString(R.string.your_score, Integer.toString(score));
        gameScoreTextView.text = newScore;

        if(!gameStarted){
            StartGame();
        }

    }

    private fun resetGame(){
        score = 0;

        val initialScore = getString(R.string.your_score, Integer.toString(score));
        gameScoreTextView.text = initialScore;

        val initialTimeLeft = getString(R.string.time_left, Integer.toString(timeLeft));
        timeLeftTextView.text = initialTimeLeft;

        countDownTimer = object : CountDownTimer(initialCountDown, countDownInternal){
            override fun onTick(millisUntilFinished: Long) {
                timeLeft = millisUntilFinished.toInt() / 1000;

                val timeLeftString = getString(R.string.time_left, Integer.toString(timeLeft));
                timeLeftTextView.text = timeLeftString;
            }

            override fun onFinish() {
                endGame();

            }
        }

        gameStarted = false;

    }

    private fun restoreGame(){
        val restored_score = getString(R.string.your_score, Integer.toString(score));
        gameScoreTextView.text = restored_score;

        val restore_time = getString(R.string.time_left, Integer.toString(timeLeft));
        timeLeftTextView.text = restore_time;

        countDownTimer = object : CountDownTimer((timeLeft * 1000).toLong(), countDownInternal){
            override fun onTick(millisUntilFinished: Long) {
                timeLeft = millisUntilFinished.toInt() / 1000;

                val timeLeftString = getString(R.string.time_left, Integer.toString(timeLeft));
                timeLeftTextView.text = timeLeftString;
            }

            override fun onFinish() {
                endGame();
            }
        }

        countDownTimer.start();
        gameStarted = false;


    }

    private fun StartGame(){
        countDownTimer.start();
        gameStarted = true;

    }

    private fun endGame(){
        Toast.makeText(this, getString(R.string.game_over_message, Integer.toString(score), 123), Toast.LENGTH_LONG).show();
        resetGame();
    }


}
