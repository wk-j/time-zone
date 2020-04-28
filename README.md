## Time zone

macOS

```bash
sudo systemsetup -gettimezone
```

Ubuntu

```bash
timedatectl
ls -l /etc/localtime

docker exec -it 651155e919b1 bash
ls /usr/share/zoneinfo/Asia/Bangkok
```

Docker

```bash
ENV TZ=Asia/Bangkok
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
```