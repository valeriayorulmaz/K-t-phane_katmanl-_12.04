alter proc kulistele
as begin 
select*from Kullanci
end
---
 alter procedure Giris
 @kad varchar(50),
 @sifre varchar(50)
 as begin 
 select*from Kullanici where kad=@kad and sifre=@sifre
 end

 
 
 create proc kullaniciekle
 @kullaniciadi varchar(50),
 @sifre varchar(50)
 as begin
 insert into Kullanici(kullaniciadi,sifre) values (@kullaniciadi,@sifre)
 end

----
create proc ulistele
as begin 
select*from Üye
end

create proc uekle
@uadsoyad varchar(50),
@utel varchar(50),
@uposta varchar(50),
@uadres varchar(50)
as begin
insert into Üye(uadsoyad,utel, uposta,uadres)values (@uadsoyad,@utel,@uposta,@uadres)
end

alter proc uyenile
@uyeno int,
@uadsoyad varchar(50),
@utel varchar(50),
@uposta varchar(50),
@uadres varchar(50)
as begin
update Üye set uadsoyad=@uadsoyad,utel=@utel,uposta=@uposta, uadres=@uadres 
where uyeno=@uyeno
end

create proc usil
@uyeno int
as begin
delete from Üye where uyeno=@uyeno
end

create proc uara
@uadsoyad varchar(50)
as begin
select*from Üye where uadsoyad=@uadsoyad
end

-------
create proc elistele
as begin 
select*from Emanet
end

alter proc eekle
@uyeno int,
@kitapno int,
@veristarihi datetime,
@iadetarihi datetime,
@kitapdurumu varchar(50)
as begin
insert into Emanet(uyeno,kitapno, veristarihi,iadetarihi,kitapdurumu)values (@uyeno,@kitapno,@veristarihi,@iadetarihi,@kitapdurumu)
end

alter proc eyenile
@emanetno int,
@uyeno int,
@kitapno int,
@veristarihi datetime,
@iadetarihi datetime,
@kitapdurumu varchar(50)
as begin
update Emanet set uyeno=@uyeno,kitapno=@kitapno,veristarihi=@veristarihi, iadetarihi=@iadetarihi ,kitapdurumu=@kitapdurumu
where emanetno=@emanetno
end

alter proc esil
@emanetno int
as begin
delete from Emanet where emanetno=@emanetno
end

alter proc eara
@kitapno varchar(50)
as begin
select*from Emanet where kitapno=@kitapno
end

-------
create proc klistele
as begin 
select*from Kitap
end

create proc kekle
@kad varchar(50),
@kyazar varchar(50),
@baskiyili int,
@sayfasayisi int,
@yayinevi varchar(50),
@dil varchar(50),
@tur varchar(50),
@rafkodu varchar(50)
as begin
insert into Kitap(kad,kyazar,baskiyili,sayfasayisi,yayinevi,dil,tur,rafkodu)values (@kad,@kyazar,@baskiyili,@sayfasayisi,@yayinevi,@dil,@tur,@rafkodu)
end

create proc kyenile
@kitapno int,
@kad varchar(50),
@kyazar varchar(50),
@baskiyili int,
@sayfasayisi int,
@yayinevi varchar(50),
@dil varchar(50),
@tur varchar(50),
@rafkodu varchar(50)
as begin
update Kitap set kad=@kad,kyazar=@kyazar,baskiyili=@baskiyili, sayfasayisi=@sayfasayisi ,yayinevi=@yayinevi,dil=@dil,tur=@tur,rafkodu=@rafkodu
where kitapno=@kitapno
end

create proc ksil
@kitapno int
as begin
delete from Kitap where kitapno=@kitapno
end

create proc kara
@kad varchar(50)
as begin
select*from Kitap where kad=@kad
end
---raporlamlar

--Kitap tablosundan dili Ýngilizce olalarýn bilgilerini getir 
create proc kitapingilizce
as begin
select * from Kitap where dil='Ýngilizce'
end

create proc kitapalmanca
as begin
select * from Kitap where dil='Almanca'
end

create proc dilsira
as begin
select *from Kitap order by dil ASC
END


--Kitap tablosundan türü  
create proc roman
as begin
select * from Kitap where tur='Roman'
end

alter proc kgelisim
as begin
select * from Kitap where tur='Kiþisel Geliþim'
end
create proc tursira
as begin
select *from Kitap order by tur ASC
END

--Sayfasayýsý

alter proc kisakitap
as begin
select * from Kitap where sayfasayisi<100
end

alter proc uzunkitap
as begin
select * from Kitap where sayfasayisi>99
end


create proc sayfasirala
as begin
select *from Kitap order by sayfasayisi ASC
END





