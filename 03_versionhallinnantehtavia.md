# Githarjoituksia

Alla on gitin perusharjoituksia. Dokumentoi suorittamasi vaiheet kuvakaappauksilla. Luo omaan repoosi versionhallinanpalautukset.md ja uusi kansio nimeltä kuvat. Kirjoita lyhyt raportti tehtävien eri vaiheista. 

Tieto markdownista: 
https://www.markdownguide.org/basic-syntax/
Kuvia saa lisättyä esimerkiksi seuraavalla tavalla:

Katso mallia alla olevasta kuvasta ja stackoverflow linkistä.
![kuva03](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/13_Picture/kuvat/picture03.png)
Lisää ohjeita löytyy: https://stackoverflow.com/questions/14494747/how-to-add-images-to-readme-md-on-github

### 1 Branchin (haara) lisääminen

Lisää omaan github repoosi uusi haara nimeltä feature1. Luo metodi, joka tekee jotain.

### Git merge

Yhdistä branchi mainiin.

### 

Editoi samaa riviä main- ja feature1-branchissa. Selvitä mahdolliset konfliktit.

### x Git ignore tehtävä

Tee oma .gitignore -tiedosto, jossa estät haluamiasi tiedostoformaatteja esimerkiksi tässä tapauksessaa .png tiedostopäättet tulisi estää. Piirrä kuva paint 3d:llä tai draw.io:lla, ja koita tallentaa ne .png muodossa
git-kansioosi.

### n Palauta vanhan brancin tila:

Lisää githubin haaraasi tiedosto "turhaa.md". Muista git add, commit ja push, jos lisäät tiedoston gitin kautta.
Palauta branchin tila takaisin edelliseen versioon, jossa turhaa.md tiedostoa ei enää ole.
Esim.

```
$ git checkout -b old-project-state 0ad5a7a6
```
