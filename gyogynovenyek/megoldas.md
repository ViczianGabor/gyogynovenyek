# Megoldás

# osztály létrehozása
- kétféle mód közül bármelyik
    - ctrl+.
    - adjuk hozzá egy osztályt
  - 5 tulajdonság
    -- public get
    -- private set

  - 1 konstruktor
    -- 1 paraméter --> string
    -- például: Acsalapu;levél;6;8
    -- ;-vel vannak elválasztva
    -- átadott, fájlból beolvasott sort:
        --- ';' mentén tagoljuk
        --- [0] ---> Nev
        --- [1] ---> resz
        --- [2] ---> Kezd
        --- [3] ---> Veg
        --- [4] ---> idotartam
        --- idotartam ---> számolása (lásd következő pont)
        -- 5. tulajdonság --> időtartam
            --- konstruktorban számoljuk
            --- számolás: vég - kezdet ha vég nagyobb mint kezdet
            --- vég > kezdet ---> vég - kezdet +1
            --- egyébként ---> 12 - vég + kezdet + 1

# adatok beolvasása és eltárolása

- listában tároljuk az objektum példányokat
- Olvassuk be:
    -- System.IO
    -- StreamReader
    -- while ciklus --> amíg tart a fájl
    -- Cikluson belül listához hozzá adunk egy új objektum példányt (beolvasott sor a paraméter)


## 1. feladat
 - hány növény van (lista count tulajdonság)

## 2. feladat
 - milyen gyűjthető részek vannak?
 - hány darab van ezekből
 - Adatszerk: Dictionary<string,int>
 - 1 milyen gyűjthető részek
    - Foreach "noveny"
    - ha a rész nem kulcs --> adjuk hozzá 0-val
 - 2 hány darab van ezekből


## 3. feladat
 - maximum keresés --> időtartam alapján
 - növény(ek) amely(ek) legtöbb ideig szedtek

## 4. feladat
 - átlag idotartam számitás