=============================
Conrad 
Image Recognition
README.md
=============================

=============================
Environment
-----------------------------
Ubuntu 17.10 x86-64 - artful
    $lsb_release -a
kernel 4.13.0-16-generic
    $uname -a
GCC 7.2.0
    $gcc --version
GLIBC 2.26
    $ldd --version
ICC
PGI
XLC
CLANG
GeForce GT 630M
    $lspci | grep -i nvidia
Kernel headers
    $sudo apt-get install linux-headers-$(uname -r)
Cuda toolkit
    cuda-repo-ubuntu1704-9-0-local_9.0.176-1_amd64.deb
Tensor Flow 
    
=============================

=============================
References
-----------------------------
https://www.tensorflow.org/install/install_linux
http://docs.nvidia.com/cuda/cuda-installation-guide-linux/index.html#pre-installation-actions
=============================


TODO
Step 0
Left off - 
Cuda at this time does not support gcc 7
We need to use an older gcc (6)
https://askubuntu.com/questions/26498/choose-gcc-and-g-version

Step 1
Pickup installation of runfile at 4.1.5.1
http://docs.nvidia.com/cuda/cuda-quick-start-guide/index.html#ubuntu-x86_64

Step 2
Pickup installation at 4 - Runfile Installation
http://docs.nvidia.com/cuda/cuda-installation-guide-linux/index.html#pre-installation-actions

