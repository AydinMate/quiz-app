<script lang="ts">

    export let answer: Answer
</script>

<label class="flex items-center space-x-2">
    <input class="checkbox" type="checkbox" on:change={() => console.log(answer.id, "clicked")} />
    <p>{answer.answer}</p>
</label>