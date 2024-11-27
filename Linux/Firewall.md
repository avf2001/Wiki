# Firewall
* [iptables (outdated)](#iptables-outdated)
* [nftables](#nftables)
* [ufw (Uncomplicated Firewall)](#ufw-uncomplicated-firewall)
* [firewalld](#firewalld)
* IPChains
* CSF
* APF
* shorewall
* ferm
* firehol

## iptables (outdated)
`iptables` is a user-space utility program that allows a system administrator to configure the IP packet filter rules of the Linux kernel firewall. It is part of the `netfilter` project.

## nftables
`nftables` is the successor to `iptables` and provides a more modern and efficient way to manage firewall rules. It is designed to be more flexible and easier to use. Introduced in Linux kernel 3.13 and is recommended for new installations.

## ufw (Uncomplicated Firewall)
`ufw` is a frontend for `iptables` that simplifies the process of managing firewall rules. It is designed to be easy to use for beginners. Commonly used in Ubuntu and other Debian-based distributions.

## firewalld
`firewalld` is a dynamic firewall manager that provides a way to manage firewall rules using zones and services. It is designed to work with `nftables` or `iptables`. Commonly used in Red Hat-based distributions like CentOS and Fedora.

### 5. **IPChains**
   - **Description**: `IPChains` is an older firewall tool that was used before `iptables`. It is no longer actively developed or recommended for use.
   - **Usage**: Rarely used today, as it has been superseded by `iptables`.
   - **Command**: `ipchains -L`

### 6. **CSF (ConfigServer Security & Firewall)**
   - **Description**: `CSF` is a third-party firewall tool designed for use on web servers. It is particularly popular among users of cPanel/WHM.
   - **Usage**: Often used on shared hosting environments.
   - **Command**: `csf -l`

### 7. **APF (Advanced Policy Firewall)**
   - **Description**: `APF` is another third-party firewall tool that was popular in the past, especially on cPanel/WHM servers. It has been largely replaced by `CSF`.
   - **Usage**: Less common today, but still used in some legacy environments.
   - **Command**: `apf -s`

### 8. **shorewall**
   - **Description**: `shorewall` is a high-level tool that allows you to create complex firewall rules using a simple configuration file. It is often used in more advanced firewall setups.
   - **Usage**: Common in environments where complex firewall rules are needed.
   - **Command**: `shorewall show rules`

### 9. **ferm**
   - **Description**: `ferm` is a wrapper for `iptables` that allows you to write firewall rules in a more readable and maintainable way using a domain-specific language.
   - **Usage**: Often used in environments where firewall rules need to be easily managed and documented.
   - **Command**: `ferm /etc/ferm/ferm.conf`

### 10. **firehol**
   - **Description**: `firehol` is a firewall manager that allows you to create complex firewall rules using a simple configuration file. It is designed to be easy to use and highly configurable.
   - **Usage**: Common in environments where complex firewall rules are needed.
   - **Command**: `firehol start`

### Summary
- **iptables**: Legacy, widely used.
- **nftables**: Modern, recommended for new installations.
- **ufw**: Simple, user-friendly.
- **firewalld**: Dynamic, common in Red Hat-based distros.
- **CSF**: Popular on cPanel/WHM servers.
- **shorewall, ferm, firehol**: Advanced, complex firewall management.

Each of these tools has its own strengths and is suited to different use cases, depending on the complexity of the firewall rules and the specific needs of the system.
