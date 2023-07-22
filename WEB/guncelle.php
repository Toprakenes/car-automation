<?php
include("Header.php");
include("baglanti.php");

$id = $_GET['id'];

$motor_getir = "SELECT * FROM motor WHERE id = $id";
$motor_sorgu = mysqli_query($baglanti, $motor_getir);
$motor = mysqli_fetch_array($motor_sorgu);

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
                <?php 

                $modelGet = $motor['model'];
                $aciklamaGet = $motor['aciklama'];
                $fiyatGet = $motor['fiyat'];
                $aralikGet = $motor['aralik'];
                $resimGet = $motor['resim_id'];
                
                echo "<form method='post'>
                <table cellpadding=0 cellspacing=0>
                    <tr height=100>
                        <td width=500><input type='text' name='model' value = '$modelGet' class='textBox'></td>
                        <td><input type='text' name='fiyat' value='$fiyatGet' class='textBox'></td>
                    </tr>
                    <tr height=250>
                        <td><textarea name='aciklama' cols='30' rows='10'
                                class='textBoxAciklama'>$aciklamaGet</textarea></td>
                        <td width=500>";

                            if($aralikGet == 'Günlük'){
                                echo "<select name='aralik' class='select'>
                                <option value='Günlük' selected>Günlük</option>
                                <option value='Haftalık'>Haftalık</option>
                                <option value='Aylık'>Aylık</option>
                            </select>";
                            }
                            else if($aralikGet == 'Haftalık'){
                                echo "<select name='aralik' class='select'>
                                <option value='Günlük'>Günlük</option>
                                <option value='Haftalık' selected>Haftalık</option>
                                <option value='Aylık'>Aylık</option>
                            </select>";
                            }
                            else{
                                echo "<select name='aralik' class='select'>
                                <option value='Günlük'>Günlük</option>
                                <option value='Haftalık'>Haftalık</option>
                                <option value='Aylık' selected>Aylık</option>
                            </select>";
                            }
                            
                            echo "
                            <br> <br>
                            <input type='text' name='resim' value='$resimGet' class='textBoxResim'>
                            <br> <br>
                            <input type='submit' name='guncelleBtn' class='submit' value='Güncelle'>
                        </td>
                    </tr>
                </table>
            </form>";
                
                ?>
                
                <?php
                if (isset($_POST["guncelleBtn"])) {
                    $model = $_POST["model"];
                    $aciklama = $_POST["aciklama"];
                    $fiyat = $_POST["fiyat"];
                    $aralik = $_POST["aralik"];
                    $resim_id = $_POST["resim"];

                    $sql = "UPDATE motor SET model = '$model', aciklama = '$aciklama', fiyat = '$fiyat', aralik = '$aralik', resim_id = '$resim_id' WHERE id = $id";
                    $git = mysqli_query($baglanti, $sql);

                    if ($git) {
                        echo "Güncelleme Başarılı";
                        header("Refresh:2; url=admin_panel.php");
                    } else {
                        echo "Güncelleme Başarısız";
                        header("Refresh:2; url=admin_panel.php");
                    }
                }
                ?>
            </center>
        </div>
    </div>

</body>


</html>