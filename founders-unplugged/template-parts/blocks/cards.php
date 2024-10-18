<?php
$image_1 = get_field('image_c_1');
$image_2 = get_field('image_c_2');
$title_1 = get_field('title_c_1');
$title_2 = get_field('title_c_2');
$stitle_1 = get_field('subtitle_с_1');
$stitle_2 = get_field('subtitle_с_2');
$descr_1 = get_field('description_с_1');
$descr_r_1 = get_field('description_rm_1');
$descr_2 = get_field('description_с_2');
$descr_r_2 = get_field('description_rm_2');
?>

    <div class="cards">
        <div class="container">
            <div class="cards-wrapper">
                <div class="card-item">
                <div class="img">
                    <?php if ($image_1): ?>
                        <?php echo wp_get_attachment_image($image_1['id'], 'full'); ?>
                    <?php endif; ?>
                </div>
                <div class="text">
                    <div class="text-visible">
                    <h3><?php echo $title_1; ?></h3>
                    <p class="sub-title"><span><?php echo $stitle_1; ?></span></p>
                        <?php echo $descr_1; ?>
                    </div>
                    <a id="read-more-2" onclick="readMoreFun('hide-text-2',this.id)" class="read-more">
                    read more
                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <g clip-path="url(#clip0_1_140)">
                        <path
                            d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                            fill="black" />
                        </g>
                        <defs>
                        <clipPath id="clip0_1_140">
                            <rect width="20" height="20" fill="white" />
                        </clipPath>
                        </defs>
                    </svg>
                    </a>
                    <div class="hide-text-2 hidden-content">
                        <?php echo $descr_r_1; ?>
                    <a onclick="readMoreFun('hide-text-2','read-more-2')" class="read-less">
                        <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M0.0245319 10.1255C0.0328525 10.1459 0.047423 10.1621 0.0594938 10.1803C0.0703145 10.1968 0.0769947 10.2151 0.0910187 10.2298L6.75796 17.2301C6.88558 17.3637 7.09653 17.3684 7.22935 17.2416C7.36283 17.1147 7.36802 16.9037 7.24106 16.7704L1.11036 10.3334L19.6667 10.3334C19.8509 10.3334 20 10.1841 20 10C20 9.81596 19.8509 9.66669 19.6667 9.66669L1.11036 9.66669L7.24106 3.22961C7.36802 3.09632 7.36283 2.88534 7.22935 2.75838C7.16489 2.69685 7.08219 2.66642 6.99953 2.66642C6.91164 2.66642 6.82374 2.70107 6.758 2.76994L0.091058 9.77021C0.077034 9.78498 0.0703148 9.80326 0.0595331 9.81971C0.0474623 9.83791 0.0329297 9.85408 0.02457 9.87455C-0.00820469 9.95499 -0.00820378 10.045 0.0245319 10.1255Z"
                            fill="black" />
                        </svg>
                        read less
                    </a>
                    </div>
                </div>
                </div>
                <div class="card-item">
                <div class="img">
                    <?php if ($image_2): ?>
                        <?php echo wp_get_attachment_image($image_2['id'], 'full'); ?>
                    <?php endif; ?>
                </div>
                <div class="text">
                    <div class="text-visible">
                    <h3><?php echo $title_2; ?></h3>
                    <p class="sub-title"><span><?php echo $stitle_2; ?></span></p>
                        <?php echo $descr_2; ?>
                    </div>
                    <a id="read-more-3" onclick="readMoreFun('hide-text-3',this.id)" class="read-more">
                    read more
                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <g clip-path="url(#clip0_1_140)">
                        <path
                            d="M19.9755 9.87454C19.9671 9.85407 19.9526 9.8379 19.9405 9.81969C19.9297 9.80325 19.923 9.78492 19.909 9.7702L13.242 2.76992C13.1144 2.63629 12.9035 2.63156 12.7707 2.75836C12.6372 2.88532 12.632 3.09626 12.7589 3.22955L18.8896 9.66664H0.333333C0.149068 9.66664 0 9.8159 0 9.99997C0 10.184 0.149107 10.3333 0.333333 10.3333H18.8896L12.7589 16.7704C12.632 16.9037 12.6372 17.1147 12.7707 17.2416C12.8351 17.3031 12.9178 17.3336 13.0005 17.3336C13.0884 17.3336 13.1763 17.2989 13.242 17.2301L19.9089 10.2298C19.923 10.215 19.9297 10.1967 19.9405 10.1803C19.9525 10.1621 19.9671 10.1459 19.9754 10.1254C20.0082 10.045 20.0082 9.95501 19.9755 9.87454Z"
                            fill="black" />
                        </g>
                        <defs>
                        <clipPath id="clip0_1_140">
                            <rect width="20" height="20" fill="white" />
                        </clipPath>
                        </defs>
                    </svg>
                    </a>
                    <div class="hide-text-3 hidden-content">
                        <?php echo $descr_r_2; ?>
                    <a onclick="readMoreFun('hide-text-3','read-more-3')" class="read-less">
                        <svg width="20" height="20" viewBox="0 0 20 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M0.0245319 10.1255C0.0328525 10.1459 0.047423 10.1621 0.0594938 10.1803C0.0703145 10.1968 0.0769947 10.2151 0.0910187 10.2298L6.75796 17.2301C6.88558 17.3637 7.09653 17.3684 7.22935 17.2416C7.36283 17.1147 7.36802 16.9037 7.24106 16.7704L1.11036 10.3334L19.6667 10.3334C19.8509 10.3334 20 10.1841 20 10C20 9.81596 19.8509 9.66669 19.6667 9.66669L1.11036 9.66669L7.24106 3.22961C7.36802 3.09632 7.36283 2.88534 7.22935 2.75838C7.16489 2.69685 7.08219 2.66642 6.99953 2.66642C6.91164 2.66642 6.82374 2.70107 6.758 2.76994L0.091058 9.77021C0.077034 9.78498 0.0703148 9.80326 0.0595331 9.81971C0.0474623 9.83791 0.0329297 9.85408 0.02457 9.87455C-0.00820469 9.95499 -0.00820378 10.045 0.0245319 10.1255Z"
                            fill="black" />
                        </svg>
                        read less
                    </a>
                    </div>
                </div>
                </div>
            </div>
        </div>
    </div>