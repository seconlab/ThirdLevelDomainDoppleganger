select * from secondlevelcounterfaster where count != 0

update secondlevelcounterfaster set count =0

select sum(count) from secondlevelcounterfaster

select secondlevelname, count from secondlevelcounterfaster group by secondlevelname order by count desc
select count, sum(count) from secondlevelcounterfaster group by count order by count desc

select * from secondlevelcounterfaster where count >= 10000 order by count desc

select * from secondlevelcounterfaster where secondlevelname like '%sharepoint%' order by count desc

select secondlevelname from secondlevelcounterfaster where dumbgrepcount = 0 and count >= 10000 order by count desc
select count(*) from secondlevelcounterfaster where smartergrepcount != 0
select count(*) from secondlevelcounterfaster where dumbgrepcount != 0
--update secondlevelcounterfaster set grepped = 1 where dumbgrepcount > 0
select 
	secondlevelname, 
	count, 
	dumbgrepcount,
	smartergrepcount, 
	(cast(dumbgrepcount as decimal(10,1)) / cast(count as decimal(10,1))) as dumbratio,
	(cast(smartergrepcount as decimal(10,1)) / cast(count as decimal(10,1))) as smarterratio 
from 
	secondlevelcounterfaster 
where 
	smartergrepcount > 1000
	and dumbgrepcount > 0
	and count > 100
	and len(secondlevelname) >= 5
	--and (cast(smartergrepcount as decimal(10,1)) / cast(count as decimal(10,1))) < 1.0
order by 
	dumbratio desc 

	
