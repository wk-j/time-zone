## Time zone

macOS

```bash
sudo systemsetup -gettimezone
```

Ubuntu

```bash
timedatectl
timedatectl list-timezones

ls /usr/share/zoneinfo/Asia/Bangkok
ls -l /etc/localtime
```

Docker (Ubuntu)

```bash
docker exec -it 651155e919b1 bash

ENV TZ=Asia/Bangkok
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

docker-compose exec app date
docker-compose exec app cat /etc/timezone
```

Test

```bash
curl -s http://localhost/api/hello/tz | jq
```