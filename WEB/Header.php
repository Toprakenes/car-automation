<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Motorum Sende</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css">
    <link rel="stylesheet" href="index.css">
    <style>
        table, th, td {
          border:1px solid #473b39;}
            
        a { color: #473b39;}
        
img {
  display: block;
  margin: 10%;
}
        </style> 
</head>
<body>
    <section id="menu">
        <div id="logo">
            <img src="resim/logo.png" width="280">
        </div>
        <nav>
            <a href="index.php"><i class="fa-solid fa-house ikon"></i>Anasayfa</a>
            <a href="hakkimizda.php"><i class="fa-solid fa-rectangle-ad ikon"></i>Hakkımızda</a>
            <?php
            if(!isset($_SESSION["ID"])) {
            echo '<a href="giris.html"><i class="fa-solid fa-right-to-bracket ikon"></i>Giriş Yap</a>';
            echo '<a href="kayit.html"><i class="fa-regular fa-id-card ikon"></i>Kayıt Ol</a>';
            }
            else{
            echo $_SESSION["KA"];
            echo '<a href="cikis.php">  ÇIKIŞ</a>';
            }
            ?>
        </nav>
    </section>
    
</body>
</html>


