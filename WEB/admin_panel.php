<?php
include("HeaderAdmin.php");
include("baglanti.php");

function motorCard($id, $model, $aciklama, $fiyat, $aralik, $resim_id)
{
    $card = "
    <div class='row mb-6'>
    <div class='col-md-4'>
        <div class='card'>
            <img src='resim/$resim_id.jpg' class='center-block' alt='...'>
            <div class='card-body'>
                <h5 class='card-title'>$model</h5>
                <p class='card-text'>$aciklama</p>
                <p class='card-text'>₺$fiyat</p>
                <p class='card-text'>$aralik</p>
                <a href='guncelle.php?id=$id' class='btn btn-sm btn-primary'>Güncelle</a>
                <a href='silok.php?id=$id' class='btn btn-sm btn-primary'>Sil</a>
            </div>
        </div>
    </div>
</div>";


    echo $card;

}

?>
<html>

<head>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css">
    <link rel="stylesheet" href="admin.css">
</head>

<body>

    <div class="container">
        <div class="ekleContainer">
            <center>
                <form method="post">
                    <table cellpadding=0 cellspacing=0>
                        <tr height=100>
                            <td width=500><input type="text" name="model" value="Motor Modeli" class="textBox"></td>
                            <td><input type="text" name="fiyat" value="Fiyat" class="textBox"></td>
                        </tr>
                        <tr height=250>
                            <td><textarea name="aciklama" cols="30" rows="10"
                                    class="textBoxAciklama">Açıklama</textarea></td>
                            <td width=500>
                                <select name="aralik" class="select">
                                    <option value="Günlük">Günlük</option>
                                    <option value="Haftalık">Haftalık</option>
                                    <option value="Aylık">Aylık</option>
                                </select>
                                <br> <br>
                                <input type="text" name="resim" value="Resim ID" class="textBoxResim">
                                <br> <br>
                                <input type="submit" name="ekleBtn" class="submit" value="Ekle">
                            </td>
                        </tr>
                    </table>
                </form>
                <?php
                if (isset($_POST["ekleBtn"])) {
                    $model = $_POST["model"];
                    $aciklama = $_POST["aciklama"];
                    $fiyat = $_POST["fiyat"];
                    $aralik = $_POST["aralik"];
                    $resim_id = $_POST["resim"];

                    $sql = "INSERT INTO motor VALUES(null,'$model','$aciklama','$fiyat','$aralik','$resim_id')";
                    $git = mysqli_query($baglanti, $sql);

                    if ($git) {
                        echo "Ekleme Başarılı";
                        header("Refresh:2; url=admin_panel.php");
                    } else {
                        echo "Ekleme Başarısız";
                        header("Refresh:2; url=admin_panel.php");
                    }
                }
                ?>
            </center>
        </div>
        <div class="containerCards">
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
                        motorCard($motor['id'],$motor['model'],$motor['aciklama'],$motor['fiyat'],$motor['aralik'],$motor['resim_id']);
                        $motor_sayisi--;
                    }
                    echo "</td>";
                }

                echo "</tr>";
            }

            echo "</table>";
            ?>
        </div>
    </div>

</body>


</html>