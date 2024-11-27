# Firewall
* [nftables](#nftables)
* [CSF (ConfigServer Security & Firewall)](#csf-configserver-security--firewall)
* [APF (Advanced Policy Firewall)](#apf-advanced-policy-firewall)
* [ferm](#ferm)
* [Debian](#debian)
  * [ufw (Uncomplicated Firewall)](#ufw-uncomplicated-firewall)
* [Red Hat](#red-hat)
  * [firewalld](#firewalld)
* [Complex](#complex)
  * [firehol](#firehol)
  * [shorewall](#shorewall)
* [Outdated](#outdated)
  * [IPChains](#ipchains)
  * [iptables](#iptables)  

## nftables
`nftables` is the successor to `iptables` and provides a more modern and efficient way to manage firewall rules. It is designed to be more flexible and easier to use. Introduced in Linux kernel 3.13 and is recommended for new installations.

## CSF (ConfigServer Security & Firewall)
`CSF` is a third-party firewall tool designed for use on web servers. It is particularly popular among users of cPanel/WHM. Often used on shared hosting environments.

## APF (Advanced Policy Firewall)
`APF` is another third-party firewall tool that was popular in the past, especially on cPanel/WHM servers. It has been largely replaced by `CSF`. Less common today, but still used in some legacy environments.

## ferm
`ferm` is a wrapper for `iptables` that allows you to write firewall rules in a more readable and maintainable way using a domain-specific language. Often used in environments where firewall rules need to be easily managed and documented.

# Debian

## ufw (Uncomplicated Firewall)
`ufw` is a frontend for `iptables` that simplifies the process of managing firewall rules. It is designed to be easy to use for beginners. Commonly used in Ubuntu and other Debian-based distributions.

# Red Hat

## firewalld
`firewalld` is a dynamic firewall manager that provides a way to manage firewall rules using zones and services. It is designed to work with `nftables` or `iptables`. Commonly used in Red Hat-based distributions like CentOS and Fedora.

# Complex

## firehol
`firehol` is a firewall manager that allows you to create complex firewall rules using a simple configuration file. It is designed to be easy to use and highly configurable. Common in environments where complex firewall rules are needed.

## shorewall
`shorewall` is a high-level tool that allows you to create complex firewall rules using a simple configuration file. It is often used in more advanced firewall setups. Common in environments where complex firewall rules are needed.

# Outdated

## IPChains
`IPChains` is an older firewall tool that was used before `iptables`. It is no longer actively developed or recommended for use. Rarely used today, as it has been superseded by `iptables`.

## iptables
`iptables` is a user-space utility program that allows a system administrator to configure the IP packet filter rules of the Linux kernel firewall. It is part of the `netfilter` project.

А ещё интересная фишка, что по умолчанию можно снаружи отличить ситуацию, когда порт закрыт,но на нём кто-то слушает от ситуации, когда никто не слушает. Первые будут косплеить чёрную дыру (пакет пришёл и исчез), вторые будут вызывать ICMP-ответ о том, что никого нет дома. Чтоб было неотличимо, надо в конце цепочки INPUT сделать iptables -A INPUT -p tcp -j REJECT --reject-with tcp-reset.

Хотелось бы больше подробностей про такую black magic в iptables как connection tracking, например:
```
-A TCP -p tcp -m tcp --dport 22 -m conntrack --ctstate NEW -m recent --set --name SSH --mask 255.255.255.255 --rsource
-A TCP -p tcp -m tcp --dport 22 -m conntrack --ctstate NEW -m recent --update --seconds 60 --hitcount 5 --rttl --name SSH --mask 255.255.255.255 --rsource -j REJECT --reject-with tcp-reset
-A TCP -p tcp -m tcp --dport 22 -j ACCEPT
```

Пользуюсь не первый год, китайских мамкиных хакеров блочит на отлично (отправляет в "бан по IP"), после чего зачастую скорее всего они отстают и вносят уже в свой "блеклист" - ну типа "с этим хостом лучше не связываться". Но все равно - для большинства - это реальный black magic (интересно, ufw/firewalld так могут?) Хотя оба - по сути обертки над iptables.

### Summary
- **iptables**: Legacy, widely used.
- **nftables**: Modern, recommended for new installations.
- **ufw**: Simple, user-friendly.
- **firewalld**: Dynamic, common in Red Hat-based distros.
- **CSF**: Popular on cPanel/WHM servers.
- **shorewall, ferm, firehol**: Advanced, complex firewall management.
