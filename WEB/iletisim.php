<?php 

include('baglanti.php');

$id = $_GET['id'];

$sql = "UPDATE rezervasyon SET iletisim='1' WHERE id=$id;";
$git = mysqli_query($baglanti,$sql);

if($git){
    echo "İletişime Geçildi";
    header("Refresh:2; url=rezervasyonlar.php");
}

?>