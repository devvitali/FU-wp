<?php
$image = get_field('image_b1');
$text = get_field('title');
?>

    <div class="top-banner">
        <?php if ($image): ?>
            <?php echo wp_get_attachment_image($image['id'], 'full'); ?>
        <?php endif; ?>
        <div class="title">
            <h1><?php echo $text; ?></h1>
        </div>
    </div>