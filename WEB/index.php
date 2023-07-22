<?php
include("Header.php");

include("baglanti.php");

function motorCard($id, $model, $aciklama, $fiyat, $aralik, $resim_id)
{
	echo "
    <div class='row mb-6'>
    <div class='col-md-4'>
        <div class='card'>
            <img src='resim/$resim_id.jpg' class='center-block' alt='...'>
            <div class='card-body'>
                <h5 class='card-title'>$model</h5>
                <p class='card-text'>$aciklama</p>
                <p class='card-text'>₺$fiyat</p>
                <p class='card-text'>$aralik</p>";

	if (!isset($_SESSION["ID"])) {
		echo "<a href='giris.html' class='btn btn-sm btn-primary'>Rezervasyon İçin Giriş Yapınız</a>";
	} else {
		echo "<a href='rezervasyon.php?id=$id' class='btn btn-sm btn-primary'>Rezervasyon Yaptır</a>";
	}

	echo "</div>
        </div>
    </div>
</div>";

}
?>

<html>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"
	integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css">
<link rel="stylesheet" href="admin.css">
<br>
<br>
<br>
<div class="container">
	<?php
	echo "<table cellspacing=30>";

	$motor_getir = "SELECT * FROM motor ORDER BY id";
	$motor_sorgu = mysqli_query($baglanti, $motor_getir);

	$motor_sayisi_getir = "SELECT COUNT(*) AS 'motor_sayisi' FROM motor";
	$motor_sayisi_sorgu = mysqli_query($baglanti, $motor_sayisi_getir);
	$motor_sayisi_select = mysqli_fetch_array($motor_sayisi_sorgu);
	$motor_sayisi = $motor_sayisi_select["motor_sayisi"];

	$satir = $motor_sayisi / 3;
	$sutun = 3;

	for ($i = 0; $i <= $satir; $i++) {
		echo "<tr>";

		for ($j = 1; $j <= $sutun; $j++) {
			echo "<td width=400>";
			if ($motor_sayisi > 0) {
				$motor = mysqli_fetch_array($motor_sorgu);
				motorCard($motor['id'], $motor['model'], $motor['aciklama'], $motor['fiyat'], $motor['aralik'], $motor['resim_id']);
				$motor_sayisi--;
			}
			echo "</td>";
		}

		echo "</tr>";
	}

	echo "</table>";
	?>
</div>
<br>

<br>

</html>