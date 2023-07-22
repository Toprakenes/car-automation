<?php 

include("baglanti.php");

$id = $_GET['id'];
$motor_sil = "DELETE FROM motor WHERE id = $id";
$motor_sorgu = mysqli_query($baglanti, $motor_sil);

if($motor_sorgu){
    header("Refresh:2; url=admin_panel.php");
}

?>