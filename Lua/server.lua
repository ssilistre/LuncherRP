-----------------------------------------------
--İlk kurulum için panel.fivemcode.com sunucu kaydettikten sonra  lütfen aşağıya keyinizi yazınız.
--------------------------------------------------
local sunucuno = 'sunucuno'


----------------------------------------------------
------MESAJLAR-------------------------------------
local oyundaMesaji='Kullanıcı şu anda oyunda !'
local banlandinMesaji='Banlısın ama ballı değilsin.'
local luncheryokMesaji='Kanka luanchersız nereye giriyorsun.'


----------------------------------------------------

----------------------------------------------------

local function OnPlayerConnecting(name, setKickReason, deferrals)
    deferrals.defer()
    deferrals.update(string.format("Merhaba %s. Launcher kontrolü sağlanıyor...", name))
	identifiers = GetPlayerIdentifiers(source)
	local hex = identifiers[1]
	Wait(5)
	PerformHttpRequest('http://api.fivemcode.com/check_user.php?sunucuid='..sunucuno..'&steamhexid='..hex..'', function(err, text, headers)
	local sonuc = text
	if sonuc == "Oyunda" then
		deferrals.done(oyundaMesaji)
	elseif sonuc == "4" then
		deferrals.done(banlandinMesaji)
	elseif sonuc == "1" then
		PerformHttpRequest('http://api.fivemcode.com/update_user.php?sunucuid='..sunucuno..'&steamhexid='..hex..'&durum=0&online=1', function(err, text2, headers)
		end, 'GET', "")
		deferrals.done()
	elseif sonuc == "0" then
		deferrals.done(luncheryokMesaji)
	else
		deferrals.done(luncheryokMesaji)
	end
	end, 'GET', "")
  
end



local function OnPlayerDrop(name)
	
	local hex = identifiers[1]
    
	PerformHttpRequest('http://api.fivemcode.com/update_user.php?sunucuid='..sunucuno..'&steamhexid='..hex..'&durum=0&online=0', function (errorCode, resultData, resultHeaders)
	  end)
	
end


AddEventHandler("playerConnecting", OnPlayerConnecting)
AddEventHandler("playerDropped", OnPlayerDrop)


