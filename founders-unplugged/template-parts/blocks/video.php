<?php
$video = get_field('video_file');
$button = get_field('form_button', 'option');
?>

    <div class="video-content">
        <div class="container">
            <div class="video-wrapper">
                <div class="video">
                <video loop controls muted playsinline autoplay poster="">
                    <source src="<?php echo $video; ?>" type="video/mp4" />
                </video>
                </div>
            </div>
            <a class="popup-link" href="#steps"><?php echo $button; ?></a>
        </div>
    </div>