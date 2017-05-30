using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mogura
{
　public partial class Form1 : Form
　{
　　　//モグラの描画座標用
　　　Point point;

　　　//モグラが出た回数カウント用
　　　int count;

　　　//モグラの位置を特定用
　　　int posision;

　　　//モグラクリック済み判定用
　　　bool clicked;

　　　public Form1()
　　　{
　　　　　　InitializeComponent();
　　　}

　　　private void Endbutton_Click(object sender , EventArgs e)
　　　{
　　　　　　Application.Exit();
　　　}

　　　private void Form1_Load(object sender , EventArgs e)
　　　{
　　　　　　//初期設定
　　　　　　Pointlabel.Text = "0";
　　　　　　count = 0;
　　　　　　clicked = false;
　　　}

　　　private void levelScrollBar_Scroll(object sender , ScrollEventArgs e)
　　　{
　　　　　　//スクロールバーの値をlevellabelに表示する
　　　　　　levellabel.Text = levelScrollBar.Value.ToString();
　　　}

　　　private void Startbutton_Click(object sender , EventArgs e)
　　　{
　　　　　　//初期設定
　　　　　　Form1_Load(null , null);

　　　　　　//各コントロールの使用可否を反転
　　　　　　ControlsEnableChange();

　　　　　　//タイマーコントロールのintervalプロパティを、レベルに合わせて設定
　　　　　　timer1.Interval = (1000 - levelScrollBar.Value * 30);

　　　　　　//タイマースタート
　　　　　　timer1.Enabled = true;
　　　}

　　　private void timer1_Tick(object sender , EventArgs e)
　　　{
　　　　　　//モグラが規定回数出現したら（ゲームが繰り返されたら、終了）
　　　　　　if (count == 15)
　　　　　　{
　　　　　　　　　//タイマーを止める
　　　　　　　　　timer1.Enabled = false;

　　　　　　　　　//コントロールの使用可否を反転
　　　　　　　　　ControlsEnableChange();

　　　　　　　　　//モグラの画像を消す（見えなくする）
　　　　　　　　　Picture.Visible = false;

　　　　　　　　　//終了
　　　　　　　　　return;
　　　　　　}

　　　　　　//モグラを出す位置を、ランダムに設定
　　　　　　point = pointpickup();

　　　　　　//ランダムに算出された位置にモグラを描画
　　　　　　Picture.Location = point;
　　　　　　Picture.Visible = true;

　　　　　　//多重クリック防止用の変数をクリア
　　　　　　clicked = false;

　　　　　　//カウントを増やす
　　　　　　count++;
　　　}

　　　private Point pointpickup()
　　　{
　　　　　　//モグラの位置を算出するための、自作メソッド
　　　　　　//乱数の設定
　　　　　　Random rnd = new Random(DateTime.Now.Millisecond);

　　　　　　//発生した乱数を変数posisionに足す
　　　　　　posision += rnd.Next(1 , 11);

　　　　　　//ランダムにモグラ描画位置posisionを設定
　　　　　　point = new Point(12 + (posision % 4) * 125 , 30 + (posision % 3) * 150);

　　　　　　//算出されたpointを返す
　　　　　　return point;
　　　}

　　　private void Picture_Click(object sender , EventArgs e)
　　　{
　　　　　　//多重クリックチェック
　　　　　　if (clicked == false)
　　　　　　{
　　　　　　　　　//得点をプラスする
　　　　　　　　　Pointlabel.Text = (Convert.ToInt32(Pointlabel.Text) +　levelScrollBar.Value).ToString();

　　　　　　　　　//多重クリック防止用に、変数にクリック済みと設定
　　　　　　　　　clicked = true;
　　　　　　}
　　　}

　　　private void ControlsEnableChange()
　　　{
　　　　　　//開始ボタン・終了ボタン・レベル設定スクロールバーの使用可否を反転する
　　　　　　Startbutton.Enabled = !Startbutton.Enabled;
　　　　　　Endbutton.Enabled = !Endbutton.Enabled;
　　　　　　levelScrollBar.Enabled = !levelScrollBar.Enabled;
　　　}
　}
}
